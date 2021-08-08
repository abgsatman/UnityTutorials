using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionExample : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "left")
        {
            Debug.Log("Left collision!");
        }
    }
}
