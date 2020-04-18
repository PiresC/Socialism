using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWord : MonoBehaviour
{

    public string word;
    private int typeIndex;

    EnemyWordDisplay display;

    public EnemyWord(string _word, EnemyWordDisplay _display)
    {
        word = _word;
        typeIndex = 0;

        display = _display;
        display.setWord(word);
    }

    public char GetNextLetter()
    {
        return word[typeIndex];
    }

    public void TypeLetter()
    {
        typeIndex++;
        //remove letter on screen
        display.removeLetter();
    }

    public bool WordTyped()
    {
        bool wordTyped = (typeIndex >= word.Length);
        if (wordTyped)
        {
            //remove the word on screen
            display.removeWord();
        }
        return wordTyped;

    }
}
