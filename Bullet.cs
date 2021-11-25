using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject Fx;

    public float damage;

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(Fx, transform.position, transform.rotation);
        if (collision.collider.CompareTag("Ai"))
        {
            collision.collider.GetComponent<Ai>().OnGetHit(damage);
        }
        Destroy(gameObject);
    }
}
