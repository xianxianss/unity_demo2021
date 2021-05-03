using UnityEngine;
using Unity.RemoteConfig;
using UnityEngine.Video;

public class ShowAnime : MonoBehaviour
{

    public struct userAttributes { }
    public struct appAttributes { }

    public bool Q1A1 = false;

    //static int counts = 0;



    public void A1action()
    {
        ConfigManager.FetchCompleted += Q1configs;
        ConfigManager.FetchConfigs<userAttributes, appAttributes>(new userAttributes(), new appAttributes());
    }




    public void Q1configs(ConfigResponse response)
    {
        Q1A1 = ConfigManager.appConfig.GetBool("Q1A1");

        if (Q1A1)
        {
            GameObject.Find("1").GetComponent<ShowBtn>().ani2.SetActive(true);
            //GetComponent<ShowBtn>().ani2.SetActive(true);
           
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

}

