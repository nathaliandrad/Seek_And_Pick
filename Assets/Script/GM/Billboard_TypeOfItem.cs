using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard_TypeOfItem : MonoBehaviour
{
    public GameObject item_description_canvas;
    // Start is called before the first frame update
    void Start()
    {
        item_description_canvas.SetActive(false);
    }
    public void OnTriggerEnter(Collider other)
    {
        item_description_canvas.SetActive(true);
        item_description_canvas.transform.rotation = Camera.main.transform.rotation;
    }
        
    public void OnTriggerExit(Collider other)
    {
        item_description_canvas.SetActive(false);
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            item_description_canvas.transform.rotation = Camera.main.transform.rotation;
        }
    }
}
