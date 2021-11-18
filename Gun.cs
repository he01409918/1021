using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class Gun : VRTK_InteractableObject
{

    public GameObject Bullet;
    public Transform FirePoint;
    public float Power;
    public override void StartUsing(VRTK_InteractUse currentUsingObject = null)
    {
        base.StartUsing(currentUsingObject);

        GameObject bullet = Instantiate(Bullet, FirePoint.position, FirePoint.rotation);
        bullet.GetComponent<Rigidbody>().AddForce(FirePoint.forward * Power);
        Debug.Log("按下板機");
    }
}
