using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthEnergy : MonoBehaviour
{
    // health energy values
    public float health;
    public float energy;
    public float MAX_HEALTH;
    public float MAX_ENERGY;
    public Slider HealthBarRight;
    public Slider HealthBarLeft;
    public Slider EnergyBarRight;
    public Slider EnergyBarleft;
    private float energyChange;

    // linking to other scripts
    public PlayerShooting shootingScript;
    public PlayerMovement movementScript;

    void Start()
    {
        MAX_HEALTH = health = 100;
        MAX_ENERGY = energy = 10000;
        shootingScript = gameObject.GetComponent<PlayerShooting>();
        movementScript = gameObject.GetComponent<PlayerMovement>();
    }

    void Update()
    {
        HealthBarRight.value = HealthBarLeft.value = (health / MAX_HEALTH) * 100;
        EnergyBarRight.value = EnergyBarleft.value = (energy / MAX_ENERGY) * 100;


        if (health <= 0)
            Destroy(gameObject);
        
        if(energy <= 0)
        {
            shootingScript.shootingEnabled = false;
            movementScript.movementEnabled = false;
        }
    }
}
