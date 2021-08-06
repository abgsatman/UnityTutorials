using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class AnimationController : MonoBehaviour
{
    [SerializeField]
    private Sprite[] images;

    [SerializeField]
    private float speed;

    void Start()
    {
        StartCoroutine(AnimationForImages());
    }

    IEnumerator AnimationForImages()
    {
        while(true)
        {
            for(int i = 0; i < images.Length; i++)
            {
                this.gameObject.GetComponent<Image>().sprite = images[i];
                yield return new WaitForSeconds(speed);
            }
        }
    }
}
