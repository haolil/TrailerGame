using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame ()
    {
        playClick();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        playClick();
        Debug.Log("QUIT");
        Application.Quit();
    }

    public void playClick()
    {
        FindObjectOfType<AudioManager>().Play("Menu_Click");
    }
    public void playBackClick()
    {
        FindObjectOfType<AudioManager>().Play("Menu_Back_Click");
    }
}
