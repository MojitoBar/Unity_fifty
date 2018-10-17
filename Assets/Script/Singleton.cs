using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    private static Singleton _instance = null;
    public static Singleton Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType(typeof(Singleton)) as Singleton;

                if (_instance == null)
                {
                    Debug.LogError("There's no active ManagerClass object");
                }
            }

            return _instance;
        }
    }

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        getdata();
    }

    public void getdata()
    {
        hearttime = PlayerPrefs.GetFloat("hearttime");
        CurHeart = PlayerPrefs.GetInt("Curheart");

        for (int i = 0; i < 5; i++)
        {
            MyScore[i] = PlayerPrefs.GetInt("Myscore" + i);
            HeartLive[i] = PlayerPrefs.GetInt("HeartLive" + i);
        }
    }

    public void setdata()
    {
        PlayerPrefs.SetFloat("hearttime", hearttime);
        PlayerPrefs.SetInt("Curheart", CurHeart);
        PlayerPrefs.SetInt("Myscore0", MyScore[0]);
        PlayerPrefs.SetInt("Myscore1", MyScore[1]);
        PlayerPrefs.SetInt("Myscore2", MyScore[2]);
        PlayerPrefs.SetInt("Myscore3", MyScore[3]);
        PlayerPrefs.SetInt("Myscore4", MyScore[4]);
        PlayerPrefs.SetInt("HeartLive0", HeartLive[0]);
        PlayerPrefs.SetInt("HeartLive1", HeartLive[1]);
        PlayerPrefs.SetInt("HeartLive2", HeartLive[2]);
        PlayerPrefs.SetInt("HeartLive3", HeartLive[3]);
        PlayerPrefs.SetInt("HeartLive4", HeartLive[4]);

        PlayerPrefs.Save();
    }

    private void Update()
    {
        if (CurHeart < 4)
        {
            hearttime -= Time.deltaTime;
            if (hearttime <= 0)
            {
                HeartLive[CurHeart + 1] = 0;
                CurHeart++;
                hearttime = 10;
            }
        }

        if (Heart[0] != null)
        {
            for (int i = 0; i < 5; i++)
            {
                if (HeartLive[i] == 1)
                {
                    Heart[i].GetComponent<Heart>().Active = true;
                }
                else
                {
                    Heart[i].GetComponent<Heart>().Active = false;
                }
            }
        }
    }

    public float hearttime = 10;
    public bool start;
    public int Score = 0;
    public int ClearScore = 0;
    public float PlayTime;

    public int CurHeart = 0;
    public GameObject[] Heart = new GameObject[5];
    public int[] HeartLive = new int[5];

    public int[] MyScore = new int[5];


    public void SetMyScore(int score)
    {
        for (int i = 0; i < 5; i++)
        {
            if (score > MyScore[i])
            {
                MyScore[0] = score;
                break;
            }
        }

        for (int i = 0; i < 4; i++)
        {
            for (int j = i + 1; j < 5; j++)
            {
                if (MyScore[i] > MyScore[j])
                {
                    int temp = MyScore[i];
                    MyScore[i] = MyScore[j];
                    MyScore[j] = temp;
                }
            }
        }
    }
}
