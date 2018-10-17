using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberCreate : MonoBehaviour
{
    List<int> L_number = new List<int>();
    public GameObject Number;

    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                GameObject obj = (GameObject)Instantiate(Number);
                obj.transform.parent = GameObject.Find("NumberPool").transform;
                obj.transform.localPosition = new Vector3(-350 + 175 * j, 410 - 175 * i);
                obj.transform.localScale = Vector3.one;

                obj.GetComponent<BlockNumber>().bkNumber = RandomNumber();
            }
        }
    }

    int RandomNumber()
    {
        int r = Random.Range(1, 26);

        while (true)
        {
            if (!L_number.Contains(r))
            {
                L_number.Add(r);
                break;
            }

            else
            {
                r = Random.Range(1, 26);
            }
        }

        return r;
    }
}
