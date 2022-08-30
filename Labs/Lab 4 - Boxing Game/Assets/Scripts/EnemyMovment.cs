using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovment : MonoBehaviour
{
    public GameObject player;

    private Animator anim;
    // Start is called before the first frame update
        void Start()
        {
            anim = GetComponent<Animator>();
        }
    
        // Update is called once per frame
        void Update()
        {
            float distance = Vector3.Distance (player.transform.position, transform.position);
            
            if (distance > 1.8f)
            {
                if (!anim.GetBool("dead"))
                {
                    transform.LookAt(new Vector3(player.transform.position.x,5,player.transform.position.z));
                    transform.position += transform.forward * 0.7f * Time.deltaTime;
                    anim.SetBool("walking",true);
                }
            }
            else
            {
                anim.SetBool("walking",false);
            }
        }
}
