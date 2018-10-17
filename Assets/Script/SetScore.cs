using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetScore : MonoBehaviour
{
    public GameObject[] Score;

    private void Update()
    {
        for (int i = 0; i < 5; i++)
        {
            Score[i].GetComponent<Text>().text = Singleton.Instance.MyScore[i].ToString();
        }
    }
}
