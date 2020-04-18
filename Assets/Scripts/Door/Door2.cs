using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door2 : MonoBehaviour
{
    private Key2 key;

    private void Start()
    {
        key = GameObject.Find("Key2").GetComponent<Key2>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && key.hasKey2)
        {
                SceneManager.LoadScene(2);
        }
    }
}
