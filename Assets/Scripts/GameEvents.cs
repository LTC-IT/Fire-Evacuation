using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System;

public class GameEvents : MonoBehaviour
{
    public static GameEvents current;

    public event Action<Collider> onCarTrigger;
    public event Action<String, int> onUpdateObjectsUI;

    public static int points = 0;
    public List<string> collectedItems;

    string[] objects = {/*0*/"Miku", /*1*/"Food", /*2*/"Water", /*3*/"LilCar", /*4*/"RBMemorabilia", /*5*/"Walkie", /*6*/"Medicine", /*7*/"Phone", 
    /*8*/"Laptop", /*9*/"Ca$h Money", /*10*/"Documents", /*11*/"Award", /*12*/"Pencil", /*13*/"Book", /*14*/"Lamp", /*15*/"Torch", /*16*/"Aidkit", /*17*/"Radio", 
    /*18*/"Battery", /*19*/"Matches", /*20*/"Mask", /*21*/"Hat", /*22*/"Plant", /*23*/"SchwarzSechsPrototypeMkII", /*24*/"Hygeine", /*25*/"Negative"};

    int[] objectValues = {/*0*/5, /*1*/10, /*2*/10, /*3*/-10, /*4*/5, /*5*/10, /*6*/10, /*7*/10, /*8*/10, /*9*/10, /*10*/10, /*11*/0, /*12*/-10, /*13*/5, 
    /*14*/-10, /*15*/10, /*16*/10, /*17*/10, /*18*/10, /*19*/10, /*20*/10, /*21*/10, /*22*/-10, /*23*/-10, /*24*/2, /*25*/-10};

    private void Awake()
    {
        current = this;
        points = 0;
    }

    private void Start()
    {
        GameEvents.current.onCarTrigger += TestCollision;
    }

    public void CarTriggerEvent(Collider hit)
    {
        if (onCarTrigger != null)
        {
            onCarTrigger(hit);
        }
    }

    public void UpdateObjectsUIEvent(String tag, int objectPoints) 
    {
        if (onUpdateObjectsUI != null)
        {
            onUpdateObjectsUI(tag, objectPoints);
        }
    }


    private void TestCollision(Collider hit)
    {
        int id = 0;
        for(int i = 0; i<objects.Length; i++){
            if(hit.gameObject.tag == objects[i]){
                id = i;
                points+=objectValues[id];
                collectedItems.Add(hit.gameObject.tag);
                for(int o = 0; o < collectedItems.Count; o++){
                    Debug.Log(collectedItems[o]);
                }
                
                UpdateObjectsUIEvent(hit.gameObject.tag, objectValues[id]);
                break;
            }
        }
    }
}