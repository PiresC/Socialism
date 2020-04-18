using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Key1 : MonoBehaviour
{
    public bool hasKey1 =false;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            hasKey1 = true;
            audioSource.Play();
            gameObject.SetActive(false);
          
        }
    }
}
