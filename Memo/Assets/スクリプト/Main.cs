using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    int number;
    string memo;
    public Text t;

    public GameObject prefab;
    public GameObject scrollview;

    GameObject text;

    // Start is called before the first frame update
    void Start()
    {
        number = PlayerPrefs.GetInt("manager");
        if (number == 0)
        {
            scrollview.SetActive(false);
            t.text = "メモはありません";
        }
        else
        {
            Memo_Management();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Memo_Management()
    {
        while (number != 0)
        {
            text = Instantiate(prefab) as GameObject;
            //memo = PlayerPrefs.GetString(number.ToString());
            //t.text = memo;
            text.transform.parent = GameObject.Find("Content").transform;
            number = number - 1;
        }
    }
}
