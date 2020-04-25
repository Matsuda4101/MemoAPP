using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class text_memory : MonoBehaviour
{
    public InputField inputfield;
    int number;
    string memo;

    // Start is called before the first frame update
    void Start()
    {
        inputfield = inputfield.GetComponent<InputField>();

        number = PlayerPrefs.GetInt("manager");
        memo = PlayerPrefs.GetString(number.ToString());
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Click()
    {
        number = PlayerPrefs.GetInt("manager".ToString(), 0);
        number = number + 1;
        PlayerPrefs.SetString(number.ToString(), inputfield.text);

        PlayerPrefs.SetInt("manager", number);
        SceneManager.LoadScene("MainScene");
    }
}
