using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehaviourFULL : MonoBehaviour
{
    public Transform goal;      // where we going   
    private NavMeshAgent agent; // this navmesh character
    private NavMeshObstacle obstacle;

    // enemy states
    public enum EnemyTypes {GruntGunner, GruntMelee };
    public EnemyTypes enemyType;

    public enum Phases {movement, charging, attacking};
    public Phases currentPhase;

    // shooting timers
    public float fireRate;
    private float timeSinceLastShot;
    public float chargeRate;
    private float chargeUpTimer;
    public float dashRate;
    private float dashTimer;

    // attack stuff
    public GameObject bulletPreset;
    public GameObject MeleePreset;
    public float weaponDamage;
    public float bulletSpeed;
    public float dashSpeed;
    bool dashInit = false;
    Vector3 dashTarget;
    public Animator walkAnimator;

    void Start()
    {
        goal = FindObjectOfType<PlayerHealthEnergy>().transform;    // look for the player
        agent = gameObject.GetComponent<NavMeshAgent>();            // rename navmesh
        agent.updateRotation = false;
        obstacle = gameObject.GetComponent<NavMeshObstacle>();
        EnableAgent(true);

        timeSinceLastShot = 0;
        chargeUpTimer = 0;
        currentPhase = Phases.movement;
    }

    void Update()
    {

        // agent goal
        if (agent.enabled) // if the navMesh is active then go to the target
        {
            agent.destination = goal.position;
        }

        // animation
        // horizontal check
        if (gameObject.transform.position.x > goal.transform.position.x)
            walkAnimator.SetInteger("Direction", -1);
        if (gameObject.transform.position.x < goal.transform.position.x)
            walkAnimator.SetInteger("Direction", 1);



        // shooting
        switch (enemyType)
        {
            // RANGED UNITS
            case EnemyTypes.GruntGunner:

                switch (currentPhase)
                {
                    case Phases.movement: // enemy is moving
                        if (timeSinceLastShot > fireRate)
                        {
                            currentPhase = Phases.charging;
                        }
                        else
                        {
                            timeSinceLastShot += Time.deltaTime;
                        }
                            break;

                    case Phases.charging:
                        walkAnimator.SetInteger("Direction", 0);
                        if (chargeUpTimer > chargeRate)
                        {
                            currentPhase = Phases.attacking;
                        }
                        else
                        {
                            EnableAgent(false);
                            chargeUpTimer += Time.deltaTime;
                        }
                            break;

                    case Phases.attacking:
                        // create a direction to shoot in
                        Quaternion direction = Quaternion.LookRotation(new Vector3(goal.position.x, transform.position.y, goal.position.z) - transform.position, transform.up);

                        ShootBullet(direction, weaponDamage, bulletSpeed);

                        timeSinceLastShot = 0 + Random.Range(-0.5f, 0.5f);  // reset timer with a little bit of random
                        chargeUpTimer = 0;  // reset charge up
                        EnableAgent(true);  // reenable movement

                        currentPhase = Phases.movement;
                            break;

                }
                break;

            // MELEE UNITS
            case EnemyTypes.GruntMelee:
                switch (currentPhase)
                {
                    case Phases.movement: // enemy is moving
                        if (timeSinceLastShot > fireRate && agent.remainingDistance <= agent.stoppingDistance)
                        {
                            currentPhase = Phases.charging;
                        }
                        else
                        {
                            timeSinceLastShot += Time.deltaTime;
                        }
                        break;

                    case Phases.charging:
                        walkAnimator.SetInteger("Direction", 0);
                        if (chargeUpTimer > chargeRate)
                        {
                            currentPhase = Phases.attacking;
                        }
                        else
                        {
                            EnableAgent(false);
                            chargeUpTimer += Time.deltaTime;
                        }
                        break;

                    case Phases.attacking:
                        if(dashTimer < dashRate) // doing dash
                        {
                            Quaternion direction = Quaternion.LookRotation(new Vector3(goal.position.x, transform.position.y, goal.position.z) - transform.position, transform.up);

                            dashTimer += Time.deltaTime; // five times as long
                            if (!dashInit)
                            {

                                dashTarget = new Vector3(dashSpeed * Mathf.Sin(direction.eulerAngles.y * Mathf.Deg2Rad), 1, dashSpeed * Mathf.Cos(direction.eulerAngles.y * Mathf.Deg2Rad));
                                dashTarget.y = 1;
                                GameObject i = Instantiate(MeleePreset, gameObject.transform);
                                MeleeDamageBall ball = i.GetComponent<MeleeDamageBall>();
                                ball._ALLIED_ = false;
                                ball.damage = weaponDamage;
                                dashInit = true;
                            }
                            EnableAgent(false);

                            gameObject.transform.position += dashTarget * Time.deltaTime;
                        }
                        else // dash finished
                        {
                            currentPhase = Phases.movement;
                            timeSinceLastShot = 0 + Random.Range(-0.5f, 0.5f);  // reset timer with a little bit of random
                            chargeUpTimer = 0;  // reset charge up
                            dashTimer = 0;
                            EnableAgent(true);  // reenable movement
                            dashInit = false;
                            foreach (Transform child in transform)// specifically delete the melee ball
                            {
                                if (child.tag == "MeleeAttackHitbox")
                                    Destroy(child.gameObject);
                            }
                        }
                        break;

                }
                break;
        }

            

    }

    void OnCollisionEnter(Collision collision) // when we collide with the player
    {
        if (collision.gameObject.CompareTag("Player"))
            EnableAgent(false);
    }

    private void OnCollisionExit(Collision collision) // when the player leaves
    {
        if(collision.gameObject.CompareTag("Player"))
            EnableAgent(true);
    }

    private void EnableAgent(bool state)
    {
        if(state == false) // if we want it off
        {
            agent.enabled = false;
            GetComponent<Rigidbody>().isKinematic = false;
            //obstacle.enabled = true;
        }
        else if (state == true)
        {
            //obstacle.enabled = false;
            agent.enabled = true;
            GetComponent<Rigidbody>().isKinematic = true;
        }
    }
    private void ShootBullet(Quaternion direction, float damage, float projSpeed)
    {
        GameObject i = Instantiate(bulletPreset,transform.position, direction) as GameObject;  // create bullet
        BulletStuff bullet = i.GetComponent<BulletStuff>();                                     // access bullet's script
        bullet._ALLIED_ = false;                                                                // do we want the bullet to damage the player?
        bullet.damage = damage;                                                           // set damage 
        bullet.MoveSpeed = projSpeed;                                                         // set speed
    }


}
