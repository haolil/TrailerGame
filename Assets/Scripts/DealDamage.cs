using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DealDamage : MonoBehaviour
{
    public float damage;
    public int killTimer;
    public bool isFinalObject;
    public GameObject winUI;

    private void OnEnable()
    {
        StartCoroutine(killObject());
        if (isFinalObject)
        {
            winUI = GameObject.Find("WinUI");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.GetComponent<PlayerHealth>())
        {
            if (isFinalObject)
            {
                winUI.GetComponent<Image>().enabled = true;
                winUI.transform.GetChild(0).gameObject.SetActive(true);
                Time.timeScale = 0f;
            }
            else
            {
                collision.transform.GetComponent<PlayerHealth>().playerHealth -= damage;
                this.transform.GetComponent<Animator>().Play("Explode");
                //Destroy(this.gameObject);
            }

        }

    }

    public IEnumerator killObject()
    {
        yield return new WaitForSeconds(killTimer);
        print("killed" + this.transform.name);
        Destroy(this.gameObject);

    }
}
