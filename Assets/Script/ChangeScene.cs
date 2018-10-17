using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    private void Update()
    {
        if (Singleton.Instance.start)
        {
            Singleton.Instance.start = false;
            Singleton.Instance.CurHeart--;
        }
    }

    public void Save()
    {
        Singleton.Instance.setdata();
    }

    public void MainToMenu()
    {
        Singleton.Instance.setdata();
        Application.LoadLevelAsync("MenuScene");
    }

    public void MenuToGame()
    {
        if (Singleton.Instance.CurHeart >= 0)
        {
            Singleton.Instance.Heart[Singleton.Instance.CurHeart].GetComponent<Heart>().Check = true;
        }
    }

    public void GameToMenu()
    {
        Singleton.Instance.SetMyScore(Singleton.Instance.ClearScore);
        Singleton.Instance.ClearScore = 0;
        Singleton.Instance.Score = 0;

        Singleton.Instance.setdata();

        Application.LoadLevelAsync("MenuScene");
    }
}
