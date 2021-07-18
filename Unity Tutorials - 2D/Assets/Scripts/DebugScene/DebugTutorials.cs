using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugTutorials : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hermes Games!");
        Debug.Log("<b>Hermes Games!</b>");
        Debug.Log("<i>Hermes Games!</i>");
        Debug.Log("<color=orange>Hermes Games!</color>");
        Debug.Log("<color=white>Hermes Games!</color>");
        Debug.Log("<size=45>Hermes Games!</size>");
        Debug.LogError("Hermes Games!");
        Debug.LogWarning("Hermes Games!");
    }

}
