using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointChangeUIScript : MonoBehaviour
{
    public int pointChange;
    Text pointsText;
    Vector3 pos;
    Color fade;


    // Start is called before the first frame update
    void Start()
    {
        pointsText = gameObject.GetComponent<Text>();

        pointsText.text = pointChange.ToString();
        pos = transform.position;

        if(pointChange >= 0) pointsText.text = "+" + pointChange.ToString();
        else pointsText.text = pointChange.ToString();

        fade = pointsText.color;
        fade.a = 1f;
        pointsText.color = fade;
    }

    // Update is called once per frame
    void Update()
    {
        fade.a -= 0.005f;
        pos += new Vector3(0, 1, 0);
        transform.position = pos;
        pointsText.color = fade;
        if(fade.a <= 0) Destroy(gameObject);
    }
}
