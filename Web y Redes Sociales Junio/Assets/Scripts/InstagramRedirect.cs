using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class InstagramRedirect : MonoBehaviour {

    public void RedirectInsta()
    {
        Application.OpenURL("https://www.instagram.com/juandsilvamora/");
    }

    public void RedirectGitHub()
    {
        Application.OpenURL("https://github.com/Juanixou");
    }

    public void Back()
    {
        SceneManager.LoadScene(0);
    }

}
