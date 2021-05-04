using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using Unity.RemoteConfig;

public class ShowBtn2 : MonoBehaviour
{
    public struct userAttributes { }
    public struct appAttributes { }

    private VideoClip vc1;
    private VideoPlayer v;
    public GameObject btn1;
    public GameObject ani2;
    public GameObject ani3;
    public GameObject ani4;

    public bool Q2A1 = false;
    public bool Q2A2 = false;
    public bool Q2A3 = false;

    private void Awake()
    {
        v = GetComponent<VideoPlayer>();
        vc1 = v.clip;
        Invoke("Show", (float)vc1.length);

    }


    public void Update()
    {
        ConfigManager.FetchCompleted += A1try2;
        ConfigManager.FetchConfigs<userAttributes, appAttributes>(new userAttributes(), new appAttributes());

        ConfigManager.FetchCompleted += A2try2;
        ConfigManager.FetchConfigs<userAttributes, appAttributes>(new userAttributes(), new appAttributes());

        ConfigManager.FetchCompleted += A3try2;
        ConfigManager.FetchConfigs<userAttributes, appAttributes>(new userAttributes(), new appAttributes());
    }



    private void Show()
    {
        btn1.SetActive(true);

    }



    public void A1try2(ConfigResponse response)
    {
        Q2A1 = ConfigManager.appConfig.GetBool("Q2A1");

        if (Q2A1)
        {
            ani2.SetActive(true);
            btn1.SetActive(false);
        }
    }

    public void A2try2(ConfigResponse response)
    {
        Q2A2 = ConfigManager.appConfig.GetBool("Q2A2");

        if (Q2A2)
        {
            ani3.SetActive(true);
            btn1.SetActive(false);
        }
    }

    public void A3try2(ConfigResponse response)
    {
        Q2A3 = ConfigManager.appConfig.GetBool("Q2A3");

        if (Q2A3)
        {
            ani4.SetActive(true);
            btn1.SetActive(false);
        }
    }
}
