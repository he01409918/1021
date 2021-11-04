using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{

    public GameObject Obj;

    public Transform Point;

    // Start is called before the first frame update
    void Start()
    {
        NewObj();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewObj()///生成
    {
        GameObject obj = Instantiate(Obj , Point.position, Point.rotation);
        Destroy(obj, 5);
        Invoke("NewObj", 3);
    }
}
