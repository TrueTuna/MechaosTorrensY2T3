using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundBurn : MonoBehaviour
{
    public float timer;
    public float damage = 2.0f;


    // Start is called before the first frame update
    void Start()
    {
        timer = 0.5f;
    }

    private void Update()
    {
        timer -= Time.deltaTime;
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Player") && timer <= 0)
        {
            timer = 0.5f;
            other.GetComponent<PlayerHealthEnergy>().health -= damage;
        }
    }
}
