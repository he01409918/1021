using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrabObject : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Rock")
        {
            TargetScore otherScore = collision.gameObject.GetComponent<TargetScore>();
            Manager.Instance.UpdateScore(otherScore.myScore);
        }
    }
}
