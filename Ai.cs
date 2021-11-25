using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Ai : MonoBehaviour
{
    private Animator anim;
    private NavMeshAgent nav;
    public Transform point;

    public float Hp;
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Hp > 0)
        {
            nav.SetDestination(point.position);
            anim.SetBool("movement", nav.remainingDistance > nav.stoppingDistance ? true : false);
        }
    }

    public void OnGetHit(float value)
    {
        if (Hp > 0)
        {
            Hp -= value;
            if (Hp <= 0)
            {
                anim.Play("Death");
            }
        }
    }

}
