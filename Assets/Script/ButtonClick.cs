using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    public GameObject Next;
    public GameObject block;
    public GameObject Clear;

    public void Start()
    {
        Next = GameObject.FindGameObjectWithTag("Next");
        Clear = GameObject.Find("ClearCanvas");
    }

    public void Click()
    {
        if (GetComponent<BlockNumber>().bkNumber == Next.GetComponent<CheckCurNumber>().CurNumber)
        {
            if (Next.GetComponent<CheckCurNumber>().CurNumber < 50)
            {
                Next.GetComponent<CheckCurNumber>().CurNumber++;
            }

            if (GetComponent<BlockNumber>().bkNumber < 26)
            {
                GameObject obj = (GameObject)Instantiate(block);
                obj.transform.parent = GameObject.Find("NumberPool").transform;
                obj.transform.localPosition = gameObject.transform.localPosition;
                obj.transform.localScale = Vector3.one;

                obj.GetComponent<BlockNumber>().bkNumber = RandomNumber();
            }

            if (100 - (int)Singleton.Instance.PlayTime > 0)
            {
                Singleton.Instance.Score += 100 - (int)Singleton.Instance.PlayTime;
            }


            if (GetComponent<BlockNumber>().bkNumber == 50)
            {
                Singleton.Instance.ClearScore = Singleton.Instance.Score;
                Clear.transform.localPosition = new Vector3(0, -130);
            }

            Destroy(gameObject);
        }
    }

    int RandomNumber()
    {
        int r = Random.Range(26, 51);

        while (true)
        {
            if (!Next.GetComponent<CheckCurNumber>().newNumber.Contains(r))
            {
                Next.GetComponent<CheckCurNumber>().newNumber.Add(r);
                break;
            }

            else
            {
                r = Random.Range(26, 51);
            }
        }

        return r;
    }
}