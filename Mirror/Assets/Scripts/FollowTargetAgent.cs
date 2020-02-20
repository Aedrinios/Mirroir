    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowTargetAgent : MonoBehaviour
{
    public bool Follow = false;

    [Space] public Transform target;
    public NavMeshAgent navAgent;

    private void OnEnable()
    {
        target = GameObject.Find("Player").transform;
    }

    void Update()
    {
        if (Follow)
            navAgent.SetDestination(target.position);
    }
}
