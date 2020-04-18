using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EnemyWordManager : MonoBehaviour
{
    public List<EnemyWord> words;
    public EnemyWordSpawner wordSpawner;


    private bool hasActiveWord;
    private EnemyWord activeWord;
    private Range enemyRange;


    private void Start()
    {
        enemyRange = GameObject.Find("Range").GetComponent<Range>();
        AddWord();
    }

   

    public void AddWord()
    {
        EnemyWord word = new EnemyWord(EnemyWordGenerator.GetRandomWord(), wordSpawner.SpawnWord());
        Debug.Log(word.word);
        words.Add(word);
    }

    public void TypeLetter(char letter)
    {
        if (hasActiveWord)
        {
            //check if letter was next
            //remove it form the word
            if (activeWord.GetNextLetter() == letter)
            {
                activeWord.TypeLetter();
            }
        }
        else
        {
            foreach (EnemyWord word in words)
            {
                if (word.GetNextLetter() == letter)
                {
                    activeWord = word;
                    hasActiveWord = true;
                    word.TypeLetter();
                    break;
                }
            }
        }

        if (hasActiveWord && activeWord.WordTyped())
        {
            hasActiveWord = false;
        }
    }
}
