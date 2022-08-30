using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spwaner : MonoBehaviour
{
    public GameObject[] cubes;

    public Transform[] points;

    public float beat = 60 / 130;
    
    float timer;
    void Start()
    {
        
    }

    void Update()
    {
        if (timer > beat)
        {
            GameObject planet = Instantiate(cubes[Random.Range(0, 2)], points[Random.Range(0, 7)]);
            planet.transform.localScale = new Vector3(0.6f, 0.6f, 0.6f);
            planet.transform.localPosition = Vector3.zero;
            timer -= beat;
        }

        timer += Time.deltaTime;
    }
}