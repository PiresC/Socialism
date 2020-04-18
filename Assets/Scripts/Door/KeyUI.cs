using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyUI : MonoBehaviour
{
    private Key1 key1;
    private Key2 key2;
    private Key3 key3;

    public Sprite sprite3;
    public Sprite sprite2;
    public Sprite sprite1;
    public Sprite spriteNull;

    public Image keyImage;


    // Start is called before the first frame update
    void Start()
    {
        key1 = GameObject.Find("Key1").GetComponent<Key1>();
        key2 = GameObject.Find("Key2").GetComponent<Key2>();
        key3 = GameObject.Find("Key3").GetComponent<Key3>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (!key1.hasKey1 || !key2.hasKey2 || !key3.hasKey3) keyImage.sprite = spriteNull;
        if (key1.hasKey1) keyImage.sprite = sprite1;
        if (key2.hasKey2) keyImage.sprite = sprite2;
        if (key3.hasKey3) keyImage.sprite = sprite3;

    }
}
