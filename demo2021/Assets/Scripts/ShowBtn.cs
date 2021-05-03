using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class ShowBtn : MonoBehaviour
{
    private VideoClip vc1;
    private VideoPlayer v;
    public GameObject btn1;
    public GameObject ani2;
   


    private void Awake()
    {
        v = GetComponent<VideoPlayer>();
        vc1 = v.clip;
        Invoke("Show", (float)vc1.length);
     

    }

    private void Show()
    {
        btn1.SetActive(true);
       
    }
    
}
