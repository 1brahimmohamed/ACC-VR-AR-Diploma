using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPoint : MonoBehaviour
{
    public GameObject followPoint;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, followPoint.transform.position)>0.20f)
        {
            transform.LookAt(new Vector3(followPoint.transform.position.x,0.28f,followPoint.transform.position.z));
            transform.position += transform.forward * 0.9f * Time.deltaTime;
            anim.SetBool("walking",true); 
        }
        else
        {
            anim.SetBool("walking",false);
        }
    }
}
