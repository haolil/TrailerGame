using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealDamage : MonoBehaviour
{
    public float damage;
    public int killTimer;
    public bool isFinalObject;
    public GameObject winUI;

    public void Start()
    {
        StartCoroutine(killObject());
        if (isFinalObject)
        {
            winUI = GameObject.Find("WinUI");
            Time.timeScale = 0f;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.GetComponent<PlayerHealth>())
        {
            if (isFinalObject)
            {
                winUI.SetActive(true);
            }
            else
            {
                collision.transform.GetComponent<PlayerHealth>().playerHealth -= damage;
                Destroy(this.gameObject);
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
