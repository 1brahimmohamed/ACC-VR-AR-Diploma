using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendRay : MonoBehaviour
{
    public GameObject followPoint;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray landingRay = new Ray(transform.position, transform.forward);

        if(OVRInput.GetDown(OVRInput.Button.One))
        {
            Debug.Log("Pressed");
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out RaycastHit hitInfo,20f))
            {
                    followPoint.transform.position = hitInfo.point;
            }
        }
    }

}
