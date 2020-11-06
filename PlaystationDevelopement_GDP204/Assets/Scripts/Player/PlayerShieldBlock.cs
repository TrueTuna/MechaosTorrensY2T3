using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShieldBlock : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other) // collision
    {
        if (other.CompareTag("BaseBullet"))
        {
            if(other.GetComponent<BulletStuff>()._ALLIED_ == false)
            {
                Destroy(other.gameObject);
            }
        }
    }
}
