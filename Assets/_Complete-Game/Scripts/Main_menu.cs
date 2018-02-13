using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_menu : MonoBehaviour
{

    // Use this for initialization
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }


    public void Roll()
    {
        SceneManager.LoadScene(1);
    }

    public void Shooter()
    {
        SceneManager.LoadScene(2);
    }

    public void Quit()
    {
        Application.Quit();

    }


}