using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public float health;
    public float MAX_HEALTH;
    public Slider HealthBarRight;
    public Slider HealthBarLeft;
    public Animator animator;

    void Start()
    {
        MAX_HEALTH = health = 100;
        animator.SetBool("Dead", false);
    }

    void Update()
    {
        HealthBarRight.value = HealthBarLeft.value = (health / MAX_HEALTH) * 100;

        if (health <= 0)
        {
            if (animator.GetCurrentAnimatorStateInfo(0).IsName("EnemyIsDead") && animator.GetBool("Dead"))
                Destroy(gameObject);

            animator.SetBool("Dead", true);

        }
    }
}
