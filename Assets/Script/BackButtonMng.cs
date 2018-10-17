using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButtonMng : MonoBehaviour
{
    public GameObject Backui;

    public void Click()
    {
        Time.timeScale = 0;
        Backui.SetActive(true);
    }

    public void Yes()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MenuScene");
    }

    public void No()
    {
        Time.timeScale = 1;
        Backui.SetActive(false);
    }
}
