using System;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public GameObject collidedObject;
    
    private void OnTriggerStay(Collider other)
    {
        collidedObject = other.gameObject;
    }
}