﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;


public class PlayerMovement : MonoBehaviour
{
    // link to other scripts
    public PlayerHealthEnergy HealthEnergyScript;
    public PlayerShooting ShootingScript;

    // on/off
    public bool movementEnabled;
    public GameObject indicator;

    // movespeed
    public float MoveSpeed = 1;

    // drain
    private float drainRate = 0.5f; // how often to drain
    private float drainAmount = 5f; // how much to drain
    private float drainTime; // since recent drain

    // animator
    public Animator walkAnimator;
    public Animator EnableAnimator;

    // controls
    PlayerControls controls;
    Vector2 controlDirection;
    private bool wPressed;
    private bool aPressed;
    private bool sPressed;
    private bool dPressed;
    

    private void Awake()
    {
        controls = new PlayerControls();
        controls.InGame.Enable();
        controls.InGame.MovementToggle.performed += context => MovementToggle();
        controls.InGame.Movement.performed += context => controlDirection = context.ReadValue<Vector2>();
        controls.InGame.Movement.canceled += context => controlDirection = Vector2.zero;

        // WASD
        controls.InGame.KeyboardUp.performed += context => wPressed = true;
        controls.InGame.KeyboardUp.canceled += context => wPressed = false;
        controls.InGame.KeyboardLeft.performed += context => aPressed = true;
        controls.InGame.KeyboardLeft.canceled += context => aPressed = false;
        controls.InGame.KeyboardDown.performed += context => sPressed = true;
        controls.InGame.KeyboardDown.canceled += context => sPressed = false;
        controls.InGame.KeyboardRight.performed += context => dPressed = true;
        controls.InGame.KeyboardRight.canceled += context => dPressed = false;
    }

    void Start()
    {
        drainTime = 0;
        movementEnabled = false;
        HealthEnergyScript = gameObject.GetComponent<PlayerHealthEnergy>();
        ShootingScript = gameObject.GetComponent<PlayerShooting>();
    }

    private void Update()
    {
    }


    void FixedUpdate()
    {
        if(movementEnabled)
        {            
            // actual movement
            if (!ShootingScript.shootingEnabled) // is the shooting script disabled?
            {
                transform.position += new Vector3(controlDirection.x * MoveSpeed * Time.deltaTime, 0, controlDirection.y * MoveSpeed * Time.deltaTime) * 1.5f;
            }
            else // if both are active
            {
                transform.position += new Vector3(controlDirection.x * MoveSpeed * Time.deltaTime, 0, controlDirection.y * MoveSpeed * Time.deltaTime);
            }

            // keyboard movement for the sake of movement
            if (wPressed)
            {
                transform.position += new Vector3(0, 0, MoveSpeed * Time.deltaTime);
            }
            if (aPressed)
            {
                transform.position += new Vector3(-MoveSpeed * Time.deltaTime, 0, 0);
            }
            if (sPressed)
            {
                transform.position += new Vector3(0, 0, -MoveSpeed * Time.deltaTime);
            }
            if (dPressed)
            {                
                transform.position += new Vector3(MoveSpeed * Time.deltaTime, 0, 0);
            }

            // relaying axis to animator
            if (controlDirection.x == 0)
            {
                switch (controlDirection.y)
                {
                    case -1:
                        walkAnimator.SetInteger("Direction", -1);
                        break;
                    case 0:
                        walkAnimator.SetInteger("Direction", 0);
                        break;
                    case 1:
                        walkAnimator.SetInteger("Direction", 1);
                        break;
                }
            }
            else
            {
                switch (controlDirection.x)
                {
                    case -1:
                        walkAnimator.SetInteger("Direction", -1);
                        break;
                    case 0:
                        walkAnimator.SetInteger("Direction", 0);
                        break;
                    case 1:
                        walkAnimator.SetInteger("Direction", 1);
                        break;
                }
            }
            
            // locking y axis
            transform.position = new Vector3(transform.position.x, 1, transform.position.z);

            // movement drain
            drainTime += Time.deltaTime;
            if (drainTime >= drainRate)
            {
                drainTime = 0;
                HealthEnergyScript.energy -= drainAmount;
            }
            indicator.GetComponent<Image>().color = new Color(0.6f, 1.0f, 0.0f);
        }
        else
        {
            indicator.GetComponent<Image>().color = new Color(1.0f, 0.1f, 0.0f);
            walkAnimator.SetInteger("Direction", 0);
        }
    }

    // toggle control
    void MovementToggle()
    {
        // enable or disable
        movementEnabled = checkForPress(movementEnabled);
        // trigger animation
        EnableAnimator.SetTrigger("Powering");
    }

    // flip flop
    bool checkForPress (bool boolean)
    {
        if(boolean)
        {
            return false;
        }
        if(!boolean)
        {
            return true;
        }
        // if all else fails
        return true;
    }


}
