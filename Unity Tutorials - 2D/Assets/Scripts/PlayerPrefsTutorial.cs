using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsTutorial : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //set variables as int and string
        if(Input.GetKey("s"))
        {
            PlayerPrefs.SetInt("a", 10);
            PlayerPrefs.SetString("b", "hermes games");

            Debug.Log("set!");
        }

        //get all of them
        if(Input.GetKey("g"))
        {
            Debug.Log("int: " + PlayerPrefs.GetInt("a"));
            Debug.Log("string: " + PlayerPrefs.GetString("b"));
        }
    }
}
