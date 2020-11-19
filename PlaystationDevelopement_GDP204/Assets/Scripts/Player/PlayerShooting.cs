using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class PlayerShooting : MonoBehaviour
{
    // link to other scripts
    public PlayerHealthEnergy HealthEnergyScript;
    public PlayerMovement MovementScript;

    // on/off toggle
    public GameObject indicator;
    public bool shootingEnabled;

    // Weapon and shield presets
    public GameObject BulletPreset;
    public GameObject PlayersShield;
    public GameObject GunSprite;
    
    // bullet's variables
    public Transform BulletSpawn;
    public float firingRate = 0.5f; // how often to shoot
    public float firingTimer; // time since last shot
    public float bulletDamage = 10;
    public float bulletSpeed = 40;

    // direction
    private Vector3 mousePosition;
    private Quaternion direction;

    // animator
    public Animator shieldAnimator;
    public Animator EnableAnimator;

    // for axis management
    private bool m_isAxisInUse = false;

    // controls
    PlayerControls controls;
    Vector2 controlDirection; // look direction
    bool controlFiring;
    bool controlBlocking;

    private void Awake()
    {
        controls = new PlayerControls();
        controls.InGame.Enable();
        // gun + aiming
        controls.InGame.WeaponsToggle.performed += context => WeaponToggle();
        controls.InGame.Aiming.performed += context => controlDirection = context.ReadValue<Vector2>();
        // blocking
        controls.InGame.Block.performed += context => controlBlocking = true;
        controls.InGame.Block.canceled += context => controlBlocking = false;
        // gun firing
        controls.InGame.Shoot.performed += context => controlFiring = true;
        controls.InGame.Shoot.canceled += context => controlFiring = false;

    }

    void Start()
    {
        firingTimer = 0;
        HealthEnergyScript = gameObject.GetComponent<PlayerHealthEnergy>();
        MovementScript = gameObject.GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        firingTimer += Time.deltaTime;

        // aiming inputs
        direction = Quaternion.LookRotation(
            new Vector3(
                transform.position.x + (10 * controlDirection.x), 
                transform.position.y, 
                transform.position.z + (10 * controlDirection.y)), 
            transform.up);
        
        // indicator colour
        if(shootingEnabled)
        { 
            indicator.GetComponent<Image>().color = new Color(0.6f, 1.0f, 0.0f);
        }
        else
        {
            indicator.GetComponent<Image>().color = new Color(1.0f, 0.1f, 0.0f);
        }

        // gun sprite facing direction
        Quaternion gunSpriteRot = direction;
        if(gunSpriteRot.eulerAngles.y < 0 || gunSpriteRot.eulerAngles.y >= 180)
            gunSpriteRot.eulerAngles += new Vector3(-90,-90, 0);
        else
            gunSpriteRot.eulerAngles += new Vector3(90,-90,0);
        GunSprite.transform.rotation = gunSpriteRot;

        // firing gun
        if(controlFiring)
        {
            WeaponFiring();
        }

        ShieldActive();
    }

    void ShieldActive() // shield is active
    {
        // shield
        if (MovementScript.movementEnabled == true && controlBlocking)
        {
            shieldAnimator.SetBool("ShieldOn", true);
            PlayersShield.SetActive(true);
            PlayersShield.transform.rotation = direction;
            HealthEnergyScript.energy -= 10 * Time.deltaTime;
        }
        else if (shieldAnimator.GetCurrentAnimatorStateInfo(0).IsName("ShieldHold") || shieldAnimator.GetCurrentAnimatorStateInfo(0).IsName("ShieldOff"))
        {
            PlayersShield.SetActive(true);
            shieldAnimator.SetBool("ShieldOn", false);
        }
        else
        {
            PlayersShield.SetActive(false);
        }
    }

    void WeaponFiring() // weapon is firing
    {
        // left click shooting
        if (shootingEnabled && firingTimer >= firingRate)
        {
            // create bullet and set its varaibles
            GameObject i = Instantiate(BulletPreset, BulletSpawn.position, direction) as GameObject;
            BulletStuff bullet = i.GetComponent<BulletStuff>();
            bullet._ALLIED_ = true;

            // set damage // reset timer
            if (!MovementScript.movementEnabled)
            {
                bullet.damage = bulletDamage * 1.5f;
                firingTimer = (firingRate / 3);
            }
            else
            {
                bullet.damage = bulletDamage;
                firingTimer = 0;
            }

            // set speed
            bullet.MoveSpeed = bulletSpeed;

            // drain energy
            HealthEnergyScript.energy -= 10;
        }
    }

    void WeaponToggle() // player has pressed the toggle button
    {
        // enable or disable
        shootingEnabled = checkForPress(shootingEnabled);
        // trigger animation
        EnableAnimator.SetTrigger("Powering");
        // button is held down so we block calling again
        //m_isAxisInUse = true;
    }
    bool checkForPress(bool boolean)
    {
        if (boolean)
        {
            return false;
        }
        if (!boolean)
        {
            return true;
        }
        // if all else fails
        return true;
    }
}
