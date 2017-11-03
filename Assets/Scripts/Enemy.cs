using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assessment2
{
    public class Enemy : MonoBehaviour
    {
        public float health = 100f; // Enemie's health which starts at 100

        public void DealDamage(float damage)
        {
            // SET health -= damage
            health -= damage;
            // IF health <= 0
            if (health <= 0)
            {
                // Destroy the enemy
                Destroy(gameObject);
            }
        }

        void OnTriggerEnter(Collider col)
        {
            if (col.tag == "Pillow")
            {
                health = health - 10;
            }
        }
        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
