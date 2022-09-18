using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepairHandler : MonoBehaviour
{
    
    Animator anim;
    public GameObject txt;

    public GameObject door;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Door"))
        {
            Debug.Log("Collided now");
            door.gameObject.SetActive(false);
        }

        else if (collision.gameObject.CompareTag("RX"))
        {
            anim = collision.gameObject.GetComponent<Animator>();
            
            if (!anim.GetBool("getOut"))
            {
                anim.SetBool("getOut",true);
                anim.SetBool("getIn", false);
            }
            else
            {
                anim.SetBool("getOut",false);
                anim.SetBool("getIn", true);
                txt.GetComponent<UnityEngine.UI.Text>().text = "Error \nSolved";
            }
        }
        
        else if (collision.gameObject.CompareTag("CloseDoor"))
        {
            door.gameObject.SetActive(true);
        }

    }
}
