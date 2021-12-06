using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public GameObject endUI;
    public Image currentHealth;
    public float maxHealth;
    public float playerHealth;
    // Start is called before the first frame update
    void Start()
    {
        playerHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        currentHealth.fillAmount = playerHealth/10;

        if(playerHealth == 0)
        {
            endUI.SetActive(true);
            Time.timeScale = 0f;

        }

    }
}
