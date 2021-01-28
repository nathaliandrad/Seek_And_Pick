using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItemManager_Level2 : MonoBehaviour
{

    public GameObject blue_can;
    public GameObject red_can;
    public GameObject chair;
    public GameObject guitar;
    public GameObject metal;
    public GameObject green_sword;
    public GameObject white_sword;
    public GameObject red_box;
    public GameObject yellow_box;
    public GameObject key;

     void Start()
    {
        Invoke("SpawnItemsLevel2",0);    
    }

    void SpawnItemsLevel2()
    {
        Vector3 pos = new Vector3(Random.Range(-18f, -88f), 20, Random.Range(-15f, 60f));
        Vector3 pos1 = new Vector3(Random.Range(-16f, -90f), 20, Random.Range(-17f, 66f));
        Vector3 pos2 = new Vector3(Random.Range(-16f, -90f), 20, Random.Range(-17f, 66f));
        Vector3 pos3 = new Vector3(Random.Range(-16f, -90f), 20, Random.Range(-17f, 66f));
        Vector3 pos4 = new Vector3(Random.Range(-16f, -90f), 20, Random.Range(-17f, 66f));
        Vector3 pos5 = new Vector3(Random.Range(-16f, -90f), 20, Random.Range(-17f, 66f));
        Vector3 pos6 = new Vector3(Random.Range(-16f, -90f), 20, Random.Range(-17f, 66f));
        Vector3 pos7 = new Vector3(Random.Range(-16f, -90f), 20, Random.Range(-17f, 66f));
        Vector3 pos8 = new Vector3(Random.Range(-16f, -90f), 20, Random.Range(-17f, 66f));

        GameObject item1 = Instantiate(blue_can, transform.position + pos, transform.rotation);
        //so when raycasting the item, dosn't appear clone
        item1.name = blue_can.name;
        GameObject item2 = Instantiate(red_can, transform.position + pos1, transform.rotation);
        //so when raycasting the item, dosn't appear clone
        item2.name = red_can.name;
        GameObject item3 = Instantiate(chair, transform.position + pos2, transform.rotation);
        //so when raycasting the item, dosn't appear clone
        item3.name = chair.name;
        GameObject item4 = Instantiate(guitar, transform.position + pos3, transform.rotation);
        //so when raycasting the item, dosn't appear clone
        item4.name = guitar.name;
        GameObject item5 = Instantiate(metal, transform.position + pos4, transform.rotation);
        //so when raycasting the item, dosn't appear clone
        item5.name = metal.name;
        GameObject item6 = Instantiate(green_sword, transform.position + pos5, transform.rotation);
        //so when raycasting the item, dosn't appear clone
        item6.name = green_sword.name;
        GameObject item7 = Instantiate(white_sword, transform.position + pos6, transform.rotation);
        //sowhen raycasting the item, dosn't appear clone
        item7.name = white_sword.name;
        GameObject item8 = Instantiate(red_box, transform.position + pos7, transform.rotation);
        //so when raycasting the item, dosn't appear clone
        item8.name = red_box.name;
        GameObject item9 = Instantiate(yellow_box, transform.position + pos8, transform.rotation);
        //so when raycasting the item, dosn't appear clone
        item9.name = yellow_box.name;
    }

    public void SpawnKey()
    {
        Debug.Log("Spawining Key");
        Vector3 pos = new Vector3(Random.Range(-16f, -90f), 20, Random.Range(-17f, 66f));
        GameObject item = Instantiate(key, transform.position + pos, transform.rotation);
        item.name = key.name;
    }
}
