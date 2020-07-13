using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
  public void PlayPenguinGame()
    {
        SceneManager.LoadScene("Penguins");
    } 


  public void PlayHummingbirdsGame()
    {
        SceneManager.LoadScene("FlowerIsland");

    }

    public void QuitGame()
    {
        Application.Quit();
    }


    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
