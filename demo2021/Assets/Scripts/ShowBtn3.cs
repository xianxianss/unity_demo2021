using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using Unity.RemoteConfig;

public class ShowBtn3 : MonoBehaviour
{
    public struct userAttributes { }
    public struct appAttributes { }

    private VideoClip vc1;
    private VideoPlayer v;
    public GameObject btn1;
 
    public GameObject ani2;
    public GameObject ani3;
    public GameObject ani4;

    public bool Q3A1 = false;
    public bool Q3A2 = false;
    public bool Q3A3 = false;

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


    // Update is called once per frame
    void Update()
    {
        ConfigManager.FetchCompleted += A1try3;
        ConfigManager.FetchConfigs<userAttributes, appAttributes>(new userAttributes(), new appAttributes());
        ConfigManager.FetchCompleted += A2try3;
        ConfigManager.FetchConfigs<userAttributes, appAttributes>(new userAttributes(), new appAttributes());
        ConfigManager.FetchCompleted += A3try3;
        ConfigManager.FetchConfigs<userAttributes, appAttributes>(new userAttributes(), new appAttributes());
    }



    public void A1try3(ConfigResponse response)
    {
        Q3A1 = ConfigManager.appConfig.GetBool("Q3A1");

        if (Q3A1)
        {
            ani2.SetActive(true);
            btn1.SetActive(false);
            
        }
    }
    public void A2try3(ConfigResponse response)
    {
        Q3A2 = ConfigManager.appConfig.GetBool("Q3A2");

        if (Q3A2)
        {
            ani3.SetActive(true);
            btn1.SetActive(false);
        }
    }   
    public void A3try3(ConfigResponse response)
    {
        Q3A3 = ConfigManager.appConfig.GetBool("Q3A3");

        if (Q3A3)
        {
            ani4.SetActive(true);
            btn1.SetActive(false);
        }
    }

}
