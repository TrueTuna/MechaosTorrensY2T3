using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBomb : MonoBehaviour
{
    // base stats
    public float MoveSpeed = 10;
    public float damage = 70;
    private float countdown;
    private float lingerTimer;

    // animator
    public Animator bulletAnimator;
    public Animator explosionAnimator;

    // parts
    public GameObject bomb;
    public GameObject explosion;


    void Start()
    {
        bomb.SetActive(true);
        explosion.SetActive(false);
        countdown = 1;
        lingerTimer = 0.6f;
    }

    void Update()
    {
        // animator
        bulletAnimator.SetBool("EnemyAnim", false);

        if (countdown >= 0) // if countdown is still going
        {
            // timer
            countdown -= Time.deltaTime;
        }
        else
        {
            bomb.SetActive(false);
            explosion.SetActive(true);
            lingerTimer -= Time.deltaTime;

            if (lingerTimer < 0 && explosionAnimator.GetCurrentAnimatorStateInfo(0).IsName("Explosion"))
            {
                Destroy(gameObject);
            }
        }
    }
    void FixedUpdate()
    {
        if (countdown >= 0) // if countdown is still going
        {
            transform.position += transform.forward * MoveSpeed * Time.deltaTime;

        }
        else
        {

        }
    }

}
