using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoCode : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        Debug.LogError("OnTriggerEnter");
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }
}
