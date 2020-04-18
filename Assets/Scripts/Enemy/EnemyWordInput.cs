using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWordInput : MonoBehaviour
{
    public EnemyWordManager wordManager;

    // Update is called once per frame
    void Update()
    {
        foreach (char letter in Input.inputString)
        {
            wordManager.TypeLetter(letter);
        }
    }
}
