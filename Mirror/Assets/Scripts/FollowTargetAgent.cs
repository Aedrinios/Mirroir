    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowTargetAgent : MonoBehaviour
{
    public Transform target;
    public NavMeshAgent navAgent;

    private void OnEnable()
    {
        target = GameObject.Find("Player").transform;
    }

    void Update()
    {
            navAgent.SetDestination(target.position);
    }
}
