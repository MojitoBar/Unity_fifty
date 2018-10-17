using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckCurNumber : MonoBehaviour
{
    public int CurNumber = 1;

    public List<int> newNumber = new List<int>();

    private void Update()
    {
        GetComponent<Text>().text = CurNumber.ToString();
    }
}
