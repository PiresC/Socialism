using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Range : MonoBehaviour
{
    private EnemyScript parent;
    public bool isInside;

    private void Start()
    {
        parent = GetComponentInParent<EnemyScript>();
    }

   private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            parent.Target = collision.transform;
        }
        isInside = true;
    }

 
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            parent.Target = null;
        }
        isInside = false;
    }
}
