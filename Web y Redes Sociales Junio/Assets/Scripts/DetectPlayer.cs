using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectPlayer : MonoBehaviour {


    private void Start()
    {

    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.name == "prueba1")
        {
            Debug.Log("Pillado!!!");
            SceneManager.LoadScene(5);
        }
       

    }
}
