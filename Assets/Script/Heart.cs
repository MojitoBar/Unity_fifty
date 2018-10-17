using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Heart : MonoBehaviour
{
    public bool Check;
    public bool Active;

    private void Update()
    {
        if (Check)
        {
            transform.GetChild(0).localScale -= new Vector3(0.1f, 0.1f);

            if (transform.GetChild(0).localScale.x < 0)
            {
                Singleton.Instance.start = true;
                Singleton.Instance.HeartLive[Singleton.Instance.CurHeart] = 1;
                Active = true;
                Singleton.Instance.setdata();
                SceneManager.LoadScene("GameScene");
            }
        }

        if (Active)
        {
            transform.GetChild(0).gameObject.SetActive(false);
        }
        else
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
    }
}
