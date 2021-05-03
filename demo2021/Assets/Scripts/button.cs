using UnityEngine;
using Unity.RemoteConfig;

public class button : MonoBehaviour
{
    
    public struct userAttributes { }
    public struct appAttributes { }

    //public bool Q1A1 = false;

    public GameObject btnl;
    public GameObject btnl2;
    
    //static int counts = 0;



    public void restart()
    {
        btnl2.SetActive(true);
    }


    public void onClick()
    {
        btnl.SetActive(false);
        //ConfigManager.FetchCompleted += Q1config; 
        //ConfigManager.FetchConfigs<userAttributes, appAttributes>(new userAttributes(), new appAttributes());
    }

   
    

    /*public void Q1config(ConfigResponse response)
    {
        Q1A1 = ConfigManager.appConfig.GetBool("Q1A1");

        if (Q1A1)
        {
            //GetComponent<ShowBtn>().btn1.SetActive(true);
            
        }

    }*/
    
    
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
