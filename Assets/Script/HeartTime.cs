using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartTime : MonoBehaviour
{
    private void Update()
    {
        if (Singleton.Instance.CurHeart != 4)
        {
            GetComponent<Text>().text = "+" + (int)Singleton.Instance.hearttime;
        }

        else
        {
            GetComponent<Text>().text = " ";
        }
    }
}
