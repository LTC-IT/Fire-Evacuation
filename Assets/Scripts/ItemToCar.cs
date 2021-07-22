using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemToCar : MonoBehaviour
{
    private void OnTriggerEnter(Collider hit)
    {
        GameEvents.current.CarTriggerEvent(hit);
        Destroy(hit.gameObject);
    }
}