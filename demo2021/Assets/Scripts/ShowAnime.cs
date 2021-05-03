using UnityEngine;
using Unity.RemoteConfig;

public class ShowAnime : MonoBehaviour
{

    public struct userAttributes { }
    public struct appAttributes { }

    public bool Q1A1 = false;

 

    //static int counts = 0;



    /*ublic void restart()
    {
        btnl2.SetActive(true);
    }*/


    public void isonClick()
    {
        ConfigManager.FetchCompleted += Q1configs;
        ConfigManager.FetchConfigs<userAttributes, appAttributes>(new userAttributes(), new appAttributes());
    }




    public void Q1configs(ConfigResponse response)
    {
        Q1A1 = ConfigManager.appConfig.GetBool("Q1A1");

        if (Q1A1)
        {
            //GetComponent<ShowBtn>().btn1.SetActive(true);
            GetComponent<button>().onClick();

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

