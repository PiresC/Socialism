using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    private PlayerController player;
    public Image heartImage;
    public Sprite sprite6;
    public Sprite sprite5;
    public Sprite sprite4;
    public Sprite sprite3;
    public Sprite sprite2;
    public Sprite sprite1;
    public Sprite sprite0;

    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerController>();
        heartImage.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.HP == 6)
            heartImage.sprite = sprite6;
        else if (player.HP == 5)
            heartImage.sprite = sprite5;
        else if (player.HP == 4)
            heartImage.sprite = sprite4;
        else if (player.HP == 3)
            heartImage.sprite = sprite3;
        else if (player.HP == 2)
            heartImage.sprite = sprite2;
        else if (player.HP == 1)
            heartImage.sprite = sprite1;
        else if (player.HP == 0)
            heartImage.sprite = sprite0;


    }
}
