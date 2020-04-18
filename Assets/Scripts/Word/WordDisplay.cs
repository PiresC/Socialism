using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour
{
    public Text text;
    public float fallspeed = 1f;


    public void setWord(string word)
    {
        text.text = word;
    }

    public void removeLetter()
    {
        text.text = text.text.Remove(0, 1);
        text.color = Color.red;
    }

    public void removeWord()
    {
        Destroy(gameObject);
    }

    private void Update()
    {
        //gerakin huruf 
        transform.Translate(-fallspeed * Time.deltaTime , 0f , 0f);
    }

 

}
