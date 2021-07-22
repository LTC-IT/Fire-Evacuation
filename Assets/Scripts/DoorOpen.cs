using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour {
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (anim != null)
            {
                Debug.Log("Space DoorOpen.cs");
                // play Bounce but start at a quarter of the way though
                anim.Play("DoorDouble_Open", -1,0);
            }
        }
    }
}