using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIOptions : MonoBehaviour
{
    public string sceneName = "Greybox";

    public void PlayGame(){
        SceneManager.LoadScene(sceneName);
        Debug.Log("Greybox");
    }

    public void QuitGame(){
        Application.Quit();
        Debug.Log("Quitting game...");
    }
}
