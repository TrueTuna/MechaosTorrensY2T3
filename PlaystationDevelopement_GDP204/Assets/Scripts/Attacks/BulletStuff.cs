using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletStuff : MonoBehaviour
{
    public bool _ALLIED_ = true; // is this a player shot bullet?


    // variables -- they should be set by the object shooting them, but if not they default to these
    public float MoveSpeed = 10;
    public float damage = 5;

    void Start()
    {
        
    }

    void FixedUpdate() // physics stuff
    {
        transform.position += transform.forward * MoveSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other) // collision
    {
        if(_ALLIED_)
        {
            // damage an enemy if we hit them
            if(other.CompareTag("Enemy"))
            {
                other.GetComponent<EnemyHealth>().health -= damage;
                Destroy(gameObject);
            }
        }
        else
        {
            // damage an enemy if we hit them
            if (other.CompareTag("Player"))
            {
                if(!other.GetComponent<PlayerMovement>().movementEnabled)
                other.GetComponent<PlayerHealthEnergy>().health -= damage * 0.2f;
                Destroy(gameObject);
            }
        }

        // delete the bullet if it travels to borders
        if(other.CompareTag("BulletDelete"))
        {
            Destroy(gameObject);
        }
    }
}
