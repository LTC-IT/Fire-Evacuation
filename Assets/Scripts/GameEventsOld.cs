using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameEventsOld : MonoBehaviour
{
    public float time;
    public float speed;
    float distance;

    // Start is called before the first frame update
    void Start()
    {
        distance = 215;
        speed = distance/time;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
