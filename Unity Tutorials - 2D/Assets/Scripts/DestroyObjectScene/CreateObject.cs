using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObject : MonoBehaviour
{
    public GameObject obj;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CreateNewObject());
    }

    IEnumerator CreateNewObject()
    {
        while(true)
        {
            //randomly
            Instantiate(obj, new Vector3(Random.Range(-0.5f, 0.5f), Random.Range(-0.75f, 0.75f), 0), Quaternion.identity);

            yield return new WaitForSeconds(0.15f);
        }
    }
}
