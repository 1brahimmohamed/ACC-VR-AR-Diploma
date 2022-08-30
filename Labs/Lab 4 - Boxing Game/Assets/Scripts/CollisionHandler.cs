using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    public GameObject txt;

    private int score;
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
        if (collision.gameObject.CompareTag("Respawn"))
        {
            Animator anim = collision.gameObject.GetComponent<Animator>();
            anim.SetBool("dead",true);
            score++;
            txt.GetComponent<UnityEngine.UI.Text>().text = "Your Score is: " + score.ToString();
        }
    }
}
