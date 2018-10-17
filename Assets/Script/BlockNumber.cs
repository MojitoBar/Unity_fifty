using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlockNumber : MonoBehaviour
{
    public int bkNumber = 0;

    void Update()
    {
        gameObject.transform.GetChild(0).GetComponent<Text>().text = bkNumber.ToString();
    }
}