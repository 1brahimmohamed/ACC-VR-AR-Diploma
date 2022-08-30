using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public GameObject PlayButtons;

    public void Hide()
    {
        PlayButtons.SetActive(false);
    }

    public void Show()
    {
        PlayButtons.SetActive(true);
    }
}
