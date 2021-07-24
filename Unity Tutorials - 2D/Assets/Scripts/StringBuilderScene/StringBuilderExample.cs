using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

public class StringBuilderExample : MonoBehaviour
{
    void Start()
    {
        //wrong
        string str = "Youtube Channel!";
        string content = "welcome to the " + str;

        //correct
        var sb = new StringBuilder();
        sb.Append(str);
        sb.Append(content);
        sb.Append("lorem ipsum");

        Debug.Log(sb.ToString());
    }
}
