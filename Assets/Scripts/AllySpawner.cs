using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assessment2
{
    public class AllySpawner : MonoBehaviour
    {
        public GameObject[] pillows;
        public Transform target;
        public float spawnRate = 1f;
        public float spawnRadius = 1f;

        void OnDrawGizmos()
        {
            Gizmos.color = Color.green;
            Gizmos.DrawWireSphere(transform.position, spawnRadius);
        }

        void Spawn()
        {
            GameObject clone = Instantiate(pillows[Random.Range(0, pillows.Length)]);

            AIAgent aiAgent = clone.GetComponent<AIAgent>();
            aiAgent.target = target;
        }

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            Spawn();
        }
    }
}
