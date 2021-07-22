using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireMover : MonoBehaviour
{
    public GameObject gameEvents;
    float timer = 0;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        float speed = gameEvents.GetComponent<GameEventsOld>().speed;
        float time = gameEvents.GetComponent<GameEventsOld>().time;
        if(timer <= time){
            transform.Translate(new Vector3(1 * Time.deltaTime, 0, 0) * -gameEvents.GetComponent<GameEventsOld>().speed, Space.Self);
        }
    }
}
