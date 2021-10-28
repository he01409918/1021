using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrabObject : MonoBehaviour
{
    public Text ScoreText;

    public float currentScore;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Rock")
        {
            TargetScore otherScore = collision.gameObject.GetComponent<TargetScore>();
            currentScore += otherScore.myScore;
            ScoreText.text = currentScore.ToString();
        }
    }
}
