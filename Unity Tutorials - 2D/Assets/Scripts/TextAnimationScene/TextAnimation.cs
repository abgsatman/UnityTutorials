using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text;

public class TextAnimation : MonoBehaviour
{
    public string textStr;
    public Text text;
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TextAnim());
    }

    IEnumerator TextAnim()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("");

        for (int i = 0; i < textStr.Length; i++)
        {
            sb.Append(textStr[i]);
            text.text = sb.ToString();
            yield return new WaitForSeconds(speed);
        }

        yield return new WaitForSeconds(0.01f);
    }
}
