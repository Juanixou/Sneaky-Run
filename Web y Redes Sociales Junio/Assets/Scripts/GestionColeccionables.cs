using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionColeccionables : MonoBehaviour {

    public List<GameObject> listaColl;
    public int numColl;
    private int rnd;


    void Start () {
        Organizar(numColl);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private int Randomize()
    {
        rnd = Random.Range(0, listaColl.Count);
        return rnd;
    }

    private void Organizar(int num)
    {
        int numEliminaciones = listaColl.Count - num;
        for(int i = 0; i < numEliminaciones; i++)
        {
            int pos = Randomize();
            Destroy(listaColl[pos]);
            listaColl.Remove(listaColl[pos]);
        }
    }

}
