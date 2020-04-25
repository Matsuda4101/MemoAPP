using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Delete_button : MonoBehaviour
{
    GameObject parent;
    int number;

    string n_memo;
    int n_number;
    GameObject n_object;

    int manager;

    // Start is called before the first frame update
    void Start()
    {
        parent = transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Click()
    {
        number = int.Parse(parent.name);
        Destroy(parent);
        while (true)
        {
            number = number + 1;
            n_number = number;
            n_memo=PlayerPrefs.GetString(n_number.ToString(),"0");
            if (n_memo == "0")
            {
                break;
            }
            PlayerPrefs.SetString((n_number - 1).ToString(), n_memo);
        }

        manager = PlayerPrefs.GetInt("manager");
        manager = manager - 1;
        PlayerPrefs.SetInt("manager", manager);

        SceneManager.LoadScene("MainScene");
    } 
}
