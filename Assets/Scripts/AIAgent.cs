﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Assessment2
{
    public class AIAgent : MonoBehaviour
    {
        public Transform target;

        private NavMeshAgent nav;
        
        // Use this for initialization
        void Awake()
        {
            nav = GetComponent<NavMeshAgent>();
        } 

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            // If target is not null
            if (target != null)
            {
                // Set destination to target's position
                nav.SetDestination(target.position);
            }
        }
    }
}
