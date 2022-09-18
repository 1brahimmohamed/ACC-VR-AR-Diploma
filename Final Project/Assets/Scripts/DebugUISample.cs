using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// Show off all the Debug UI components.
public class DebugUISample : MonoBehaviour
{
    bool inMenu;

    void Start()
    {
        string ScreenName = SceneManager.GetActiveScene().name;

        if (ScreenName == "DebugUI")
        {
            DebugUIBuilder.instance.AddButton("Start", StartButtonPressed);
            DebugUIBuilder.instance.AddDivider();
            DebugUIBuilder.instance.AddButton("Credits", CreditsButtonPressed);
            DebugUIBuilder.instance.AddDivider();
            DebugUIBuilder.instance.AddButton("Quit", QuitButtonPressed);
            DebugUIBuilder.instance.AddDivider();
        }
        else if (ScreenName == "DeviceUI")
        {
            DebugUIBuilder.instance.AddButton("Ultrasound", USButtonPressed);
            DebugUIBuilder.instance.AddDivider();
            DebugUIBuilder.instance.AddButton("X-Ray", NotImplementedPressed);
            DebugUIBuilder.instance.AddDivider();
            DebugUIBuilder.instance.AddButton("MRI", NotImplementedPressed);
            DebugUIBuilder.instance.AddDivider();
            DebugUIBuilder.instance.AddButton("Back", BackButtonPressed);
            DebugUIBuilder.instance.AddDivider();
        }
        else if (ScreenName == "Errors")
        {
            DebugUIBuilder.instance.AddButton("Error I", ErrorIPressed);
            DebugUIBuilder.instance.AddDivider();
            DebugUIBuilder.instance.AddButton("Error III", NotImplementedPressed);
            DebugUIBuilder.instance.AddDivider();
            DebugUIBuilder.instance.AddButton("Error III", NotImplementedPressed);
            DebugUIBuilder.instance.AddDivider();
            DebugUIBuilder.instance.AddButton("Back", BackButtonPressed);
            DebugUIBuilder.instance.AddDivider();
        }
        DebugUIBuilder.instance.Show();
        inMenu = true;
    }




    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.Two) || OVRInput.GetDown(OVRInput.Button.Start))
        {
            if (inMenu) DebugUIBuilder.instance.Hide();
            else DebugUIBuilder.instance.Show();
            inMenu = !inMenu;
        }
    }

    void StartButtonPressed()
    {
        Debug.Log("Start pressed");
        SceneManager.LoadScene("DeviceUI");

    }

    void CreditsButtonPressed()
    {
        Debug.Log("Credits pressed");
    }

    void QuitButtonPressed()
    {
        Debug.Log("Quit pressed");
        Application.Quit();
    }

    void USButtonPressed()
    {
        Debug.Log("Ultrasound pressed");
        SceneManager.LoadScene("Errors");
    }
    
    void BackButtonPressed()
    {
        string screenName = SceneManager.GetActiveScene().name;
        
        Debug.Log("Back");
        
        if (screenName == "DeviceUI")
        {
            SceneManager.LoadScene("DebugUI");
        }
        else if (screenName == "Errors")
        {
            SceneManager.LoadScene("DeviceUI");
        }
    }

    void ErrorIPressed()
    {
        SceneManager.LoadScene("morgue");
    }

    void NotImplementedPressed()
    {
        Debug.Log("Not Implemented Yet");
    }

}
