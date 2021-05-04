using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using Unity.RemoteConfig;

public class ShowBtn : MonoBehaviour
{
    public struct userAttributes { }
    public struct appAttributes { }

    private VideoClip vc1;
    private VideoPlayer v;
    public GameObject btn1;
    public GameObject ani2;
    public GameObject ani3;
    public GameObject ani4;

    public bool Q1A1 = false;
    public bool Q1A2 = false;
    public bool Q1A3 = false;

    private void Awake()
    {
        v = GetComponent<VideoPlayer>();
        vc1 = v.clip;
        Invoke("Show", (float)vc1.length);

    }



   public void Update()
    {
        ConfigManager.FetchCompleted += A1try;
        ConfigManager.FetchConfigs<userAttributes, appAttributes>(new userAttributes(), new appAttributes());

        ConfigManager.FetchCompleted += A2try;
        ConfigManager.FetchConfigs<userAttributes, appAttributes>(new userAttributes(), new appAttributes());

        ConfigManager.FetchCompleted += A3try;
        ConfigManager.FetchConfigs<userAttributes, appAttributes>(new userAttributes(), new appAttributes());
    }



    private void Show()
    {
        btn1.SetActive(true);
       
    }



   public void A1try(ConfigResponse response)
    {
        Q1A1 = ConfigManager.appConfig.GetBool("Q1A1");

        if(Q1A1)
        {
            ani2.SetActive(true);
            btn1.SetActive(false);
        }
    }

    public void A2try(ConfigResponse response)
    {
        Q1A2 = ConfigManager.appConfig.GetBool("Q1A2");

        if (Q1A2)
        {
            ani3.SetActive(true);
            btn1.SetActive(false);
        }
    }

    public void A3try(ConfigResponse response)
    {
        Q1A3 = ConfigManager.appConfig.GetBool("Q1A3");

        if (Q1A3)
        {
            ani4.SetActive(true);
            btn1.SetActive(false);
        }
    }







    /* public void Q1A1configs(ConfigResponse response)
     {
         Q1A1 = ConfigManager.appConfig.GetBool("Q1A1");

         if (Q1A1)
         {
             GameObject.Find("1").GetComponent<ShowBtn>().ani2.SetActive(true);
             //GetComponent<ShowBtn>().ani2.SetActive(true);

         }

     }

     public void Q1A2configs(ConfigResponse response)
     {
         Q1A2 = ConfigManager.appConfig.GetBool("Q1A2");

         if (Q1A2)
         {
             GameObject.Find("1").GetComponent<ShowBtn>().ani3.SetActive(true);
         }
     }

     public void Q1A3configs(ConfigResponse response)
     {
         Q1A3 = ConfigManager.appConfig.GetBool("Q1A3");

         if (Q1A3)
         {
             GameObject.Find("1").GetComponent<ShowBtn>().ani4.SetActive(true);
         }
     }*/

}
