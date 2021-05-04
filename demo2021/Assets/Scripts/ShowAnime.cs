using UnityEngine;
using Unity.RemoteConfig;
using UnityEngine.Video;

public class ShowAnime : MonoBehaviour
{

    public struct userAttributes { }
    public struct appAttributes { }

    public bool Q1A1 = false;
    public bool Q1A2 = false;
    public bool Q1A3 = false;

    //static int counts = 0;



    public void A1action()
    {
        ConfigManager.FetchCompleted += Q1A1configs;
        ConfigManager.FetchConfigs<userAttributes, appAttributes>(new userAttributes(), new appAttributes());
    }

    public void A2action()
    {
        ConfigManager.FetchCompleted += Q1A2configs;
        ConfigManager.FetchConfigs<userAttributes, appAttributes>(new userAttributes(), new appAttributes());
    }

    public void A3action()
    {
        ConfigManager.FetchCompleted += Q1A3configs;
            ConfigManager.FetchConfigs<userAttributes, appAttributes>(new userAttributes(), new appAttributes());
    }



    public void Q1A1configs(ConfigResponse response)
    {
        Q1A1 = ConfigManager.appConfig.GetBool("Q1A1");

        if (Q1A1)
        {
            //GameObject.Find("1").GetComponent<ShowBtn>().ani2.SetActive(true);
            GetComponent<ShowBtn>().ani2.SetActive(true);

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
}


}


   













    // public void Vote()
    //{
    // counts++;
    // Q1A1 = ConfigManager.appConfig.GetInt("Q1A1",counts);
    //  if (Q1A1)
    //{
    // counts[0]++;
    //}

    //}



