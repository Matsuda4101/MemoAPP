using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Title_Memory : MonoBehaviour
{
    int manager;
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        manager = PlayerPrefs.GetInt("manager", 0);

        if (manager == 0)
        {
            PlayerPrefs.SetInt("manager", 0);
            PlayerPrefs.SetString(manager.ToString(), "0");
        }
        text.text = "メモ数：" + manager;
    }

    // Update is called once per frame
    void Update()
    {
        DontDestroyOnLoad(this);
    }
}
