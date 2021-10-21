using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DemoCode : MonoBehaviour
{

    public int curretScore;
    public Text ScoreText;

    public void OnTriggerEnter(Collider other)
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "02")
        {
            DemoCode2 otherScore = collision.collider.GetComponent<DemoCode2>();
            curretScore += otherScore.myScore;
            ScoreText.text = curretScore.ToString();
            Debug.LogError("我碰到吐司了");
        }
        if (collision.collider.name == "BaseFloor")
        {
            curretScore -= 10;
            ScoreText.text = curretScore.ToString();
            Debug.LogError("我碰到地板了");
        }
    }
}
