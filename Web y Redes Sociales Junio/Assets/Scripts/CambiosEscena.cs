using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiosEscena : MonoBehaviour {

    public void CargarContacto()
    {
        SceneManager.LoadScene(1);
    }

    public void CargarListaNiveles()
    {
        SceneManager.LoadScene(2);
    }

    public void CargarNivel1()
    {
        SceneManager.LoadScene(3);
    }

    public void CargarNivel2()
    {
        SceneManager.LoadScene(4);
    }

    public void CargarMenu()
    {
        SceneManager.LoadScene(0);
    }


}
