using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time : MonoBehaviour
{
    public bool Start = false;
    float time_;

    void Update()
    {
        if (Start)
        {

            if (GameObject.Find("NumberPool").transform.childCount != 0)
            {
                time_ += Time.deltaTime;
                Singleton.Instance.PlayTime = time_; 
            }

            GetComponent<Text>().text = (Mathf.Round(time_ * 100) / 100).ToString();
        }
    }
}
