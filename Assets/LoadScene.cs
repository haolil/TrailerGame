using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public GameObject UIButton;
    public GameObject curtain;
    Animator anim;

    public void Start()
    {
        anim = curtain.GetComponent<Animator>();
    }
    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    
    public void TheEnd()
    {
        UIButton.SetActive(true);
        anim.Play("CuratainClose");
        
    }
}
