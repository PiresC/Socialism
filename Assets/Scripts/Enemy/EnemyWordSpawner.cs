using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWordSpawner : MonoBehaviour
{
    public GameObject wordEnemyPrefab;
    public Transform wordCanvas;

    public EnemyWordDisplay SpawnWord()
    {
        GameObject wordObj =  Instantiate(wordEnemyPrefab, wordCanvas);
        EnemyWordDisplay wordDisplay = wordObj.GetComponent<EnemyWordDisplay>();

        return wordDisplay;
    }
}
