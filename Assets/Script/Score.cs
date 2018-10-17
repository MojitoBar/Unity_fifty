using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    void Update()
    {
        GetComponent<Text>().text = Singleton.Instance.Score.ToString();
    }
}
