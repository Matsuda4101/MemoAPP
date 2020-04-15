using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test : MonoBehaviour
{
    public InputField inputfield;
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        inputfield = inputfield.GetComponent<InputField>();
        text = text.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = inputfield.text;
    }
}
