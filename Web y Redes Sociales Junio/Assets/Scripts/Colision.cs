using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision : MonoBehaviour {

    public GameObject player;
    PickCollectables pick;


    // Use this for initialization
    void Start () {
        pick = player.GetComponent<PickCollectables>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("COLISION!!!");
        if (other.tag == "Player")
        {
            pick.PickUp();
            Destroy(this.gameObject);
        }
    }
}
