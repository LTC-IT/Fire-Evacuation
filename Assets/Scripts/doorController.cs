using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorController : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject door;

    void Update() {
        // if (Input.GetKeyDown(KeyCode.Space))
        // {
        //      Debug.Log("space");
        //     door.GetComponent<Animator>().Play("Base Layer.DoorDouble_Open"); //Should play the animation

        // }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "PFB_DoorDouble")
        {
           
             Debug.Log("Now the animation clip should play");
            door.GetComponent<Animator>().Play("DoorDouble_Open"); //Should play the animation
           
        }
    }
}
