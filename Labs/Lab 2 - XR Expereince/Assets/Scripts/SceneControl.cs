using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    public void loadScene()
    {
        string scene1 = "SampleScene";
        string scene2 = "SC2";

        string ScreenName = SceneManager.GetActiveScene().name;
        
        if(ScreenName == scene1)
        {
            ScreenName = scene2;
        }
        else
        {
            ScreenName = scene1;
        }
        
        SceneManager.LoadScene(ScreenName);
    }
}
