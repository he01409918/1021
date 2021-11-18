using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Manager : MonoBehaviour
{
    public static Manager Instance;

    public GameObject Obj;

    public Transform Point;

    public Text ScoreText;

    public float currentScore;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        NewObj();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject gun = GameObject.Find("Gun");
            if (gun == null)
            {
                Debug.LogError("請將槍改名為Gun");
                return;
            }
            gun.GetComponent<Gun>().Fire();
        }
    }

    public void UpdateScore(float score) ///更新文字
    {
        currentScore += score;
        ScoreText.text = currentScore.ToString();
    }

    public void NewObj()///生成
    {
        GameObject obj = Instantiate(Obj , Point.position, Point.rotation);
        Destroy(obj, 5);
        Invoke("NewObj", 3);
    }
}
