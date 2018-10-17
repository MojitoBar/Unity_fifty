using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public GameObject GoTime;
    float time;
    
    private void Update()
    {
        Singleton.Instance.setdata();
        time += Time.deltaTime;

        if (1.0f > time && time > 0f)
        {
            GetComponent<Text>().text = 3.ToString();
        }

        if (2.0 > time && time >= 1.0f)
        {
            GetComponent<Text>().text = 2.ToString();
        }

        if (3.0 > time && time >= 2.0f)
        {
            GetComponent<Text>().text = 1.ToString();
        }

        if (time >= 3.0)
        {
            GetComponent<Text>().text = "Start!";
        }

        if (3.5f < time)
        {
            GoTime.GetComponent<time>().Start = true;
            Destroy(gameObject);
        }
    }
}
