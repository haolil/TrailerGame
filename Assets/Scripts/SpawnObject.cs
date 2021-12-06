using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public GameObject[] spawnEnemy;
    public GameObject finalEnemy;
    public int spawnCount;
    public int spawnTimer;
    public bool hasFinalEnemy;
    public bool canSpawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnCount > 0 && canSpawn)
        {

            StartCoroutine(EnemySpawn());
            canSpawn = false;

        }
        else
        {
            if (finalEnemy && hasFinalEnemy && spawnCount == 0)
            {

                StartCoroutine(FinalEnemySpawn());
                hasFinalEnemy = false;
            }

        }

    }

    public IEnumerator EnemySpawn()
    {


        yield return new WaitForSeconds(spawnTimer);
        canSpawn = true;
        spawnCount--;

        if (spawnEnemy.Length != 1)
        {
            int rand = Random.Range(0, spawnEnemy.Length);
            Instantiate(spawnEnemy[rand],this.transform.position, this.transform.rotation);
            print("rand = " + rand);
            print("3");
        }
        else
        {
            Instantiate(spawnEnemy[0], this.transform.position, this.transform.rotation);
            print("1");
        }


    }

    public IEnumerator FinalEnemySpawn()
    {
        yield return new WaitForSeconds(spawnTimer);

        Instantiate(finalEnemy, this.transform.position, this.transform.rotation);
        print("2");
    }

}
