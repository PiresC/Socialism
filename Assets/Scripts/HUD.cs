using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    private Sprite[] HeartSprites;

    public Image HeartUI;
    private PlayerController player;

    void Start(){
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    void Update(){
        //HeartUI.sprite = HeartSprites[player.currHealth];
    }
}
