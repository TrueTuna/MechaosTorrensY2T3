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
        if(Input.GetKeyDown(KeyCode.Q))
        {
            movementEnabled = checkForPress(movementEnabled);
        } 
    }

    void FixedUpdate()
    {
        if(movementEnabled)
        {
            // actual movement
            if (!ShootingScript.shootingEnabled)
            {
                transform.position += new Vector3(0, 0, Input.GetAxis("Vertical") * MoveSpeed * Time.deltaTime) * 1.5f;
                transform.position += new Vector3(Input.GetAxis("Horizontal") * MoveSpeed * Time.deltaTime, 0, 0) * 1.5f;
            }
            else;
            {
                transform.position += new Vector3(0, 0, Input.GetAxis("Vertical") * MoveSpeed * Time.deltaTime);
                transform.position += new Vector3(Input.GetAxis("Horizontal") * MoveSpeed * Time.deltaTime, 0, 0);
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
