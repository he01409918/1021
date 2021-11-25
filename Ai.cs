using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Ai : MonoBehaviour
{
    private Animator anim;
    private NavMeshAgent nav;

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
            nav.SetDestination(Manager.Instance.Player.transform.position);
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
                Destroy(gameObject, 5);
            }
        }
    }

}
