using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameExit : MonoBehaviour
{
    // Start is called before the first frame update
     public void OnTriggerEnter(Collider other)
    { 
        Debug.Log(other);
        Application.Quit();
    }
}
