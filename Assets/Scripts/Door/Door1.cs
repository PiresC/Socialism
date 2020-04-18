using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door1 : MonoBehaviour
{
    private Key1 key;
    private bool open = false;


    private void Start()
    {
        key = GameObject.Find("Key1").GetComponent<Key1>();
    }

    void Update()
    {
        if (open)
        {
            open = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player"  && key.hasKey1)
        {
            gameObject.SetActive(false);
            key.hasKey1 = false;
            open = true;
        }
    }

}
