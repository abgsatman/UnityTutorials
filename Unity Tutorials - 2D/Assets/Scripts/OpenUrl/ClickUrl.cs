using UnityEngine;

public class ClickUrl : MonoBehaviour
{
    [SerializeField]
    private string url = "http://hermesgames.com";
    
    public void OpenUrl()
    {
        Application.OpenURL(url);
    }
}
