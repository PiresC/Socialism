using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyWordDisplay : MonoBehaviour
{

    public Text text;
   

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
        //remove enemy object
        Destroy(transform.parent.parent.gameObject);
        //this.transform.parent.parent.gameObject.SetActive(false);

    }
}
