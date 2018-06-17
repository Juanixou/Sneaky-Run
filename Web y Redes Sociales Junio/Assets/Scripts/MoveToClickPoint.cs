using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class MoveToClickPoint : MonoBehaviour {
    NavMeshAgent agent;
    Animator anim;
    int layerMask;
    private float count;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        count = 180;
    }

    void Update()
    {
        count -= Time.deltaTime;

        if(count <= 0.0f)
        {
            SceneManager.LoadScene(5);
        }

        if (Input.GetMouseButtonDown(0))
        {

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

        }

        if (!agent.pathPending && agent.remainingDistance < 0.1f)
        {
            anim.SetBool("Andar", false);
        }

    }

    void OnGUI()
    {


        var style = new GUIStyle { fontSize = 48, fontStyle = FontStyle.Normal };

        //GUI.Label(new Rect(Screen.width - Screen.width / 6, 0, Screen.width, Screen.height), "s left ",style);
        GUI.Label(new Rect(Screen.width - Screen.width / 5, 0, 100, 100), Mathf.Round(count).ToString(), style);
        GUI.color = Color.white;
    }


}