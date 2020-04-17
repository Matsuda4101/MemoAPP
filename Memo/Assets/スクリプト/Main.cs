using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    int number;
    string memo;
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        number = PlayerPrefs.GetInt("manager");
        if (number == 0)
        {
            text.text = "メモはありません";
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
            memo = PlayerPrefs.GetString(number.ToString());
            text.text = memo;
            number = number - 1;
        }
    }
}
