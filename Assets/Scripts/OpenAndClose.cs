using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenAndClose : MonoBehaviour
{
    public Animator anim;
    public bool animTrigger = false;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) animTrigger = !animTrigger;
        //anim.SetBool("isOpen_Obj_1", animTrigger);
    }

    void OnTriggerEnter(Collider Player)
    {
        if (Player.name=="Sphere")
        {
        Debug.Log(Player.name);
        animTrigger = !animTrigger;
        anim.SetBool("isOpen_Obj_1", animTrigger);
        }
    }

    void OnTriggerExit(Collider Player)
    {
        Debug.Log("trigger exit");
        //animTrigger = !animTrigger;
        anim.SetBool("isOpen_Obj_1", false);
    }
}
