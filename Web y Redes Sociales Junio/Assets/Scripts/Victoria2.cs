﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victoria2 : MonoBehaviour
{


    public void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(8);
    }
}
