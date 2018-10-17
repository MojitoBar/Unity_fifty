using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartMng : MonoBehaviour
{
    private void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            Singleton.Instance.Heart[i] = transform.GetChild(i).gameObject;
        }
    }
}
