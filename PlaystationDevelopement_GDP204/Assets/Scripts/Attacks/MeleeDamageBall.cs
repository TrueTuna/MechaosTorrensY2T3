using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeDamageBall : MonoBehaviour
{
    public bool _ALLIED_ = false;
    public float damage = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other) // collision
    {
        if (_ALLIED_)
        {
            // damage an enemy if we hit them
            if (other.CompareTag("Enemy"))
            {
                other.GetComponent<EnemyHealth>().health -= damage;
            }
        }
        else
        {
            // damage an enemy if we hit them
            if (other.CompareTag("Player"))
            {
                other.GetComponent<PlayerHealthEnergy>().health -= damage;
            }
        }
    }
}
