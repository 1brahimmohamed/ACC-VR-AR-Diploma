using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spwaner : MonoBehaviour
{
    public GameObject enemy;
    float time = 10;
    void Update()
    {
        time -= Time.deltaTime;
        if (time <= 0)
        {
            Instantiate(
                enemy, 
                new Vector3(
                    UnityEngine.Random.Range(-3.5f,3.5f),
                    5,
                    UnityEngine.Random.Range(-3.4f, 3.4f)), 
                enemy.transform.rotation);
            time = 10;
        }
    }
}
