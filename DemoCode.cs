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
        if (collision.collider.tag == "02")
        {
            Debug.LogError("我碰到吐司了");
        }
        if (collision.collider.name == "BaseFloor")
        {
            Debug.LogError("我碰到地板了");
        }
    }
}
