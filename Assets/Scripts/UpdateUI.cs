using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateUI : MonoBehaviour
{
    public GameObject[] UIElements;

    public Text pointsText;
    
    public GameObject pointChangeTextPrefab;

    void Start()
    {
        pointsText.text = "Points: " + GameEvents.points.ToString();

        GameEvents.current.onUpdateObjectsUI += UpdateScore;
        GameEvents.current.onUpdateObjectsUI += UpdateEssentialUI;
    }

    private void UpdateScore(string tag, int objectPoints){
        pointsText.text = "Points: " + GameEvents.points.ToString();
        GameObject pointChangeText = Instantiate(pointChangeTextPrefab, new Vector3(107, 81, 0), Quaternion.identity);
        pointChangeText.transform.SetParent(gameObject.transform);
        pointChangeText.GetComponent<PointChangeUIScript>().pointChange = objectPoints;
    }

    private void UpdateEssentialUI(string tag, int objectPoints){
        for(int i = 0; i < UIElements.Length; i++){
            if(UIElements[i].name == tag){
                UIElements[i].GetComponent<Image>().color = Color.red;
                break;
            }
        }
    }
}
