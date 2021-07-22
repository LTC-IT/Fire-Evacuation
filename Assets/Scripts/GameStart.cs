using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnTriggerEnter(Collider other)
    { 
        Debug.Log(other);
        SceneManager.LoadScene("Greybox");
        Debug.Log("Load game");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Greybox");
            Debug.Log("Load game");
        }
    }

}
