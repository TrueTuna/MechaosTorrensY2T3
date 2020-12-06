using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthEnergy : MonoBehaviour
{
    // health energy values
    public float health;
    public float energy;
    public float MAX_HEALTH = 100;
    public float MAX_ENERGY = 10000;
    public Slider HealthBarRight;
    public Slider HealthBarLeft;
    public Slider EnergyBarRight;
    public Slider EnergyBarleft;
    private float energyChange;
    private float healthChange;
    public RawImage bloodEffect;
    private float colorValue;

    // linking to other scripts
    public PlayerShooting shootingScript;
    public PlayerMovement movementScript;

    // animator
    public Animator animator;


    void Start()
    {
        health = MAX_HEALTH;
        healthChange = health;
        energy = MAX_ENERGY;
        shootingScript = gameObject.GetComponent<PlayerShooting>();
        movementScript = gameObject.GetComponent<PlayerMovement>();
        bloodEffect.color = new Color(0, 0, 0, 0);
        colorValue = 0;
        animator.SetBool("Dead", false);
    }

    void Update()
    {
        HealthBarRight.value = HealthBarLeft.value = (health / MAX_HEALTH) * 100;
        EnergyBarRight.value = EnergyBarleft.value = (energy / MAX_ENERGY) * 100;

        if (health <= 0)
        {
            if (animator.GetCurrentAnimatorStateInfo(0).IsName("PlayerIsDead") && animator.GetBool("Dead"))
            {
                Destroy(gameObject);
            }
            animator.SetBool("Dead", true);
        }

        if (energy <= 0)
        {
            shootingScript.shootingEnabled = false;
            movementScript.movementEnabled = false;
        }

        if(health != healthChange)
        {
            colorValue = 0.3f;
            if (health == 0)
            {
                colorValue = 0.0f;
            }
        }

        colorValue -= Time.deltaTime / 2;
        bloodEffect.color = new Color(1, 0, 0, colorValue);


        healthChange = health;
    }
}
