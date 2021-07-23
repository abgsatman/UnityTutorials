using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshExample : MonoBehaviour
{
    public NavMeshAgent player;
    public GameObject target;

    // Update is called once per frame
    void Update()
    {
        player.SetDestination(target.transform.position);
    }
}
