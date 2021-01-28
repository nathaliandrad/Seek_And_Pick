using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsManager : MonoBehaviour
{
    public GameObject knife;
    public GameObject box;
    public GameObject ball;
    public GameObject table;
    public GameObject pants;
    public GameObject key;

    void Start()
    {
        Invoke("SpawnItems", 0);
    }

    void SpawnItems()
    {
        Vector3 pos = new Vector3(Random.Range(-40f, 40f), 10, Random.Range(35f, 118f));
        Vector3 pos2 = new Vector3(Random.Range(-40f, 40f), 10, Random.Range(35f, 118f));
        Vector3 pos3 = new Vector3(Random.Range(-40f, 40f), 10, Random.Range(35f, 118f));
        Vector3 pos4 = new Vector3(Random.Range(-40f, 40f), 10, Random.Range(35f, 118f));
        Vector3 pos5 = new Vector3(Random.Range(-40f, 40f), 10, Random.Range(35f, 118f));
        GameObject item1 = Instantiate(knife, transform.position + pos, transform.rotation);
        //so when raycasting the item, dosn't appear clone
        item1.name = knife.name;
        GameObject item2 = Instantiate(box, transform.position + pos2, transform.rotation);
        item2.name = box.name;
        GameObject item3 = Instantiate(ball, transform.position + pos3, transform.rotation);
        item3.name = ball.name;
        GameObject item4 = Instantiate(table, transform.position + pos4, transform.rotation);
        item4.name = table.name;
        GameObject item5 = Instantiate(pants, transform.position + pos5, transform.rotation);
        item5.name = pants.name;
    }

    public void SpawnKey()
    {
        Debug.Log("Spawining Key");
        Vector3 pos = new Vector3(Random.Range(-40f, 40f), 10, Random.Range(35f, 118f));
        GameObject item = Instantiate(key, transform.position + pos, transform.rotation);
        item.name = key.name;
    }

}
