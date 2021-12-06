using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VictimScript : MonoBehaviour
{
    public GameObject winUI;
    public GameObject losuUI;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerHealth>())
        {
            winUI.GetComponent<Image>().enabled = true;
            winUI.transform.GetChild(0).gameObject.SetActive(true);
            //Time.timeScale = 0f;
        }

        if(collision.name == "Level3Goal(Clone)")
        {
            losuUI.SetActive(true);
        }

    }



}
