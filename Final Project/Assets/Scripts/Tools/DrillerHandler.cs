using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrillerHandler : MonoBehaviour
{

    public AudioSource audio;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        OVRGrabbable grabbable = this.gameObject.GetComponent<OVRGrabbable>();
        
        if (grabbable.grabbedBy != null)
        {
            if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, grabbable.grabbedBy.m_controller) && grabbable.isGrabbed) {
                audio.Play();
            }
        }
    }
}
