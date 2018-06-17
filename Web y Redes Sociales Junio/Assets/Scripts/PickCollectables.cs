using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PickCollectables : MonoBehaviour {

    public int nCollectables;
    private GameObject puerta;
    private int nPicked;
    private AudioSource sounds;
    public AudioClip moneda;
    public AudioClip puertaAbierta;

    private void Start()
    {
        sounds = GetComponent<AudioSource>();
        nPicked = 0;
        puerta = GameObject.Find("Puerta");
    }

    private void Update()
    {
    }

    public void PickUp()
    {
        sounds.PlayOneShot(moneda);
        nPicked++;
        if (nPicked == nCollectables)
        {
            sounds.PlayOneShot(puertaAbierta);
            Destroy(puerta);
            
        }
    }


}
