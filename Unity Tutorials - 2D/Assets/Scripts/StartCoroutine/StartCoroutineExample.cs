using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCoroutineExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitFor());
    }

    IEnumerator WaitFor()
    {
        while(true)
        {
            yield return new WaitForSeconds(1f);
            Debug.Log("1 second...");
        }
    }
}
