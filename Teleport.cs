using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour  
{
    public Transform teleportPoint;  
    private void OnTriggerEnter (Collider other) {
        Transform othertrasform = other.GetComponent<Transform>();
        if (othertrasform) {
            othertrasform.position = teleportPoint.position;
        }
    }
}
