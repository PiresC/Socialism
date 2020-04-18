using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door3 : MonoBehaviour
{
    private Key3 key;

    private void Start()
    {
        key = GameObject.Find("Key3").GetComponent<Key3>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && key.hasKey3)
        {
                gameObject.SetActive(false);
                key.hasKey3 = false;
    
        }
    }
}
