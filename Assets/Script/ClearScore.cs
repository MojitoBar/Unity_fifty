using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearScore : MonoBehaviour
{

    void Update()
    {
        GetComponent<Text>().text = Singleton.Instance.ClearScore.ToString();
    }
}
