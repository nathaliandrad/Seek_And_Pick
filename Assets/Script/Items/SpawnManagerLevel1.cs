using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerLevel1 : MonoBehaviour
{
    public GameObject ladder;
    public GameObject poster;
    public GameObject rose;
    public GameObject toy;
    public GameObject tv;
    public GameObject battery;
    public GameObject key;

    void Start()
    {
        Invoke("SpawnItemsLevel1", 0);
    }

    void SpawnItemsLevel1()
    {
        Vector3 pos = new Vector3(Random.Range(-28f, 8.0f), 10, Random.Range(-100f, -48f));
        Vector3 pos1 = new Vector3(Random.Range(-28f, 8.0f), 10, Random.Range(-100f, -48f));
        Vector3 pos2 = new Vector3(Random.Range(-28f, 8.0f), 10, Random.Range(-100f, -48f));
        Vector3 pos3 = new Vector3(Random.Range(-28f, 8.0f), 10, Random.Range(-100f, -48f));
        Vector3 pos4 = new Vector3(Random.Range(-28f, 8.0f), 10, Random.Range(-100f, -48f));
        Vector3 pos5 = new Vector3(Random.Range(-28f, 8.0f), 10, Random.Range(-100f, -48f));

        GameObject item1 = Instantiate(ladder, transform.position + pos, transform.rotation);
        //so when raycasting the item, dosn't appear clone
        item1.name = ladder.name;
        GameObject item2 = Instantiate(poster, transform.position + pos1, transform.rotation);
        item2.name = poster.name;
        GameObject item3 = Instantiate(rose, transform.position + pos2, transform.rotation);
        item3.name = rose.name;
        GameObject item4 = Instantiate(toy, transform.position + pos3, transform.rotation);
        item4.name = toy.name;
        GameObject item5 = Instantiate(tv, transform.position + pos4, transform.rotation);
        item5.name = tv.name;
        GameObject item6 = Instantiate(battery, transform.position + pos5, transform.rotation);
        item6.name = battery.name;
    }

    public void SpawnKey()
    {
        Debug.Log("Spawining Key");
        Vector3 pos = new Vector3(Random.Range(-28f, 8.0f), 10, Random.Range(-100f, -48f));
        GameObject item = Instantiate(key, transform.position + pos, transform.rotation);
        item.name = key.name;
    }
}
