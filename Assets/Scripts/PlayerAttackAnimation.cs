using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackAnimation : MonoBehaviour
{
    public int childCount;
    public int temp;
    public bool attacking;

    // Start is called before the first frame update
    void Start()
    {
        temp = getChildren(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        childCount = getChildren(gameObject);
        if (childCount < temp)
            attacking = true;
        temp = childCount;
    }

    public int getChildren(GameObject obj)
    {
        int count = 0;

        for (int i = 0; i < obj.transform.childCount; i++)
        {
            count++;
            counter(obj.transform.GetChild(i).gameObject, ref count);
        }
        return count;
    }

    private void counter(GameObject currentObj, ref int count)
    {
        for (int i = 0; i < currentObj.transform.childCount; i++)
        {
            count++;
            counter(currentObj.transform.GetChild(i).gameObject, ref count);
        }
    }


}
