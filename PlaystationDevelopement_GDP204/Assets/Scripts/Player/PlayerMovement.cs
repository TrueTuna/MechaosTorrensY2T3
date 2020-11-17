using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public PlayerHealthEnergy HealthEnergyScript;
    public PlayerShooting ShootingScript;

    public bool movementEnabled;
    public float MoveSpeed = 1;

    public GameObject indicator;
    private float drainRate = 0.5f; // how often to drain
    private float drainAmount = 5f; // how much to drain
    private float drainTime; // since recent drain

    private Rigidbody rb;
    public Animator walkAnimator;
    public Animator EnableAnimator;

    // axis management
    private bool m_isAxisInUse = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        drainTime = 0;
        movementEnabled = false;
        HealthEnergyScript = gameObject.GetComponent<PlayerHealthEnergy>();
        ShootingScript = gameObject.GetComponent<PlayerShooting>();
    }

    private void Update()
    {
        // enable and disable
        if(Input.GetAxis("Trigger Movement") == 1)
        {
            if (m_isAxisInUse == false)
            {                
                // enable or disable
                movementEnabled = checkForPress(movementEnabled);
                // trigger animation
                EnableAnimator.SetTrigger("Powering");
                // block repeated fucntion activation
                m_isAxisInUse = true;
            }
        }
        else
        {
            // button is not pressed and therefore can be unset
            m_isAxisInUse = false;
        }
    }

    void FixedUpdate()
    {
        if(movementEnabled)
        {
            if (Input.mousePresent) // if a mouse is found
            {
                // actual movement
                if (!ShootingScript.shootingEnabled)
                {
                    transform.position += new Vector3(0, 0, Input.GetAxis("Move Vertical") * MoveSpeed * Time.deltaTime) * 1.5f;
                    transform.position += new Vector3(Input.GetAxis("Move Horizontal") * MoveSpeed * Time.deltaTime, 0, 0) * 1.5f;
                }
                else
                {
                    transform.position += new Vector3(0, 0, Input.GetAxis("Move Vertical") * MoveSpeed * Time.deltaTime);
                    transform.position += new Vector3(Input.GetAxis("Move Horizontal") * MoveSpeed * Time.deltaTime, 0, 0);
                }

                // relaying axis to animator
                if (Input.GetAxis("Move Horizontal") == 0)
                {
                    switch (Input.GetAxis("Move Vertical"))
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
                    switch (Input.GetAxis("Move Horizontal"))
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
            }
            else // you have a joystick
            {
                // actual movement
                if (!ShootingScript.shootingEnabled)
                {
                    transform.position += new Vector3(0, 0, Input.GetAxis("VerticalMoveJoystick") * MoveSpeed * Time.deltaTime) * 1.5f;
                    transform.position += new Vector3(Input.GetAxis("HorizontalMoveJoystick") * MoveSpeed * Time.deltaTime, 0, 0) * 1.5f;
                }
                else
                {
                    transform.position += new Vector3(0, 0, Input.GetAxis("VerticalMoveJoystick") * MoveSpeed * Time.deltaTime);
                    transform.position += new Vector3(Input.GetAxis("HorizontalMoveJoystick") * MoveSpeed * Time.deltaTime, 0, 0);
                }

                // relaying axis to animator
                if (Input.GetAxis("HorizontalMoveJoystick") == 0)
                {
                    switch (Input.GetAxis("VerticalMoveJoystick"))
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
                    switch (Input.GetAxis("HorizontalMoveJoystick"))
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
