using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void PlayGame()
    {

        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {

        Application.Quit();
        Debug.Log("Spiel wird beendet");
    }



}
