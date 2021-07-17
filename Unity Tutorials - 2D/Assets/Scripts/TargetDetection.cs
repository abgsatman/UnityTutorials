using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class TargetDetection : MonoBehaviour
{
    public GameObject target;
    public GameObject enemy;

    public float speed;

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = (target.transform.position - enemy.transform.position).normalized;
        enemy.transform.position += direction * speed * Time.deltaTime;
    }
}
