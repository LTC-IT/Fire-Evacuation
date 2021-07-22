using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class countDown : MonoBehaviour {

    public int allowedTime = 10;
    private Text textField;
    private int currentTime;

    void Awake () {
        // sets the current time to be the maximum time
        currentTime = allowedTime;
        // connect to the GUI Asset 
        textField = GetComponent<Text>();
        // Update the GUI text 
        UpdateTimerText();
        // Updates the timer using a coroutine 
        StartCoroutine(Tick()); 
    }

    void UpdateTimerText() {
        textField.text = currentTime.ToString();
    }

    IEnumerator Tick() {
        Debug.Log(currentTime);
        while (currentTime > 0) {
            // wait for a second
            yield return new WaitForSeconds (1);
            //reduce current time by 1
            currentTime--;
            // Update the screen GUI
            UpdateTimerText();
        }
        yield return new WaitForSeconds (3);
        //SceneManager.LoadScene(0);
    }
}