using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public GameObject Fx;

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(Fx, transform.position, transform.rotation);
    }
}
