using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpawner : MonoBehaviour
{
    public GameObject wordPrefab;
    public Transform wordCanvas;
    
    public WordDisplay SpawnWord()
    {
        //buat nge spawn word di random position
        Vector3 randomPosition = new Vector3( 12f, Random.Range(-4.5f, 0f));
                                                                                                            //parameter utk random
        GameObject wordObj =  Instantiate(wordPrefab,randomPosition, Quaternion.identity, wordCanvas);      //Quarternion.idenmtity = biar g ad rotasi
        WordDisplay wordDisplay = wordObj.GetComponent<WordDisplay>();

        return wordDisplay;
    }
}
