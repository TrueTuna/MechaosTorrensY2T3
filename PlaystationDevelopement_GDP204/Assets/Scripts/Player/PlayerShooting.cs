using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerShooting : MonoBehaviour
{
    public PlayerHealthEnergy HealthEnergyScript;
    public PlayerMovement MovementScript;
    public GameObject indicator;

    // bullet shooting
    public bool shootingEnabled;
    public GameObject BulletPreset;
    public GameObject PlayersShield;
    public GameObject GunSprite;
    public Transform BulletSpawn;
    public float firingRate = 0.5f; // how often to shoot
    private float firingTimer; // time since last shot

    // bullet's variables
    public float bulletDamage = 10;
    public float bulletSpeed = 40;

    private Vector3 mousePosition;
    private Quaternion direction;

    void Start()
    {
        firingTimer = 0;
        HealthEnergyScript = gameObject.GetComponent<PlayerHealthEnergy>();
        MovementScript = gameObject.GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        firingTimer += Time.deltaTime;

        // enable and disable
        if (Input.GetKeyDown(KeyCode.E))
        {
            shootingEnabled = checkForPress(shootingEnabled);
        }

        // create ray and line it up
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit))
        {
            mousePosition = hit.point;
        }
        direction = Quaternion.LookRotation(new Vector3(mousePosition.x, transform.position.y, mousePosition.z) - transform.position, transform.up);

        if(shootingEnabled)
        {
            // left click shooting
            if (Input.GetMouseButton(0) == true && firingTimer >= firingRate)
            {
                // create bullet and set its varaibles
                GameObject i = Instantiate(BulletPreset, BulletSpawn.position, direction) as GameObject;
                BulletStuff bullet = i.GetComponent<BulletStuff>();
                bullet._ALLIED_ = true;

                // set damage // reset timer
                if(!MovementScript.movementEnabled)
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
            indicator.GetComponent<Image>().color = new Color(0.6f, 1.0f, 0.0f);
        }
        else
        {
            indicator.GetComponent<Image>().color = new Color(1.0f, 0.1f, 0.0f);
        }

        // shield
        if (Input.GetMouseButton(1) == true && MovementScript.movementEnabled == true)
        {
            PlayersShield.SetActive(true);
            PlayersShield.transform.rotation = direction;
            HealthEnergyScript.energy -= 10 * Time.deltaTime;
        }
        else
        {
            PlayersShield.SetActive(false);
        }

        // gun sprite
        Quaternion gunSpriteRot = direction;
        if(gunSpriteRot.eulerAngles.y < 0 || gunSpriteRot.eulerAngles.y >= 180)
            gunSpriteRot.eulerAngles += new Vector3(-90,-90, 0);
        else
            gunSpriteRot.eulerAngles += new Vector3(90,-90,0);
        GunSprite.transform.rotation = gunSpriteRot;
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
