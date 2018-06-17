using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveToClickPoint : MonoBehaviour {
    NavMeshAgent agent;
    Animator anim;
    int layerMask;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //RaycastHit hit;
            RaycastHit[] hits = Physics.RaycastAll(Camera.main.ScreenPointToRay(Input.mousePosition), 100);

            for(int i = 0; i < hits.Length; i++)
            {
                if (hits[i].collider.tag == "Puerta")
                {
                    break;
                }
                if(hits[i].collider.tag != "Walls")
                {
                    agent.destination = hits[i].point;
                    anim.SetBool("Andar", true);
                    break;
                }
            }

            //if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            //{
            //    agent.destination = hit.point;
            //    anim.SetBool("Andar", true);
            //}
        }

        if (!agent.pathPending && agent.remainingDistance < 0.1f)
        {
            anim.SetBool("Andar", false);
        }

    }
    

}