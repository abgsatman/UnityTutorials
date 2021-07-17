using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MenuItemTutorial : MonoBehaviour
{
    [MenuItem("HermesGames/Hello Youtube!")]
    static void HelloYoutube()
    {
        Debug.Log("Hello Youtube :)");
    }
}
