using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Manager : MonoBehaviour
{
    Transform Canvas;
    Transform Btn;
    TextMeshProUGUI Txt;

    int value = 0;

    void Start()
    {
        Canvas = GameObject.Find("Canvas").transform;
        Btn = Canvas.Find("Btn");
        Txt = Btn.Find("Txt").GetComponent<TextMeshProUGUI>();

        value = PlayerPrefs.GetInt("value");
        WriteAndSaveValue();
    }

    public void Clicked()
    {
        value++;
        WriteAndSaveValue();
    }

    public void ResetBtn()
    {
        value = 0;
        WriteAndSaveValue();
    }

    void WriteAndSaveValue()
    {
        Txt.text = value.ToString();
        if (value > 999)
        {
            Txt.fontSize = 300;
        }
        else
        {
            Txt.fontSize = 400;
        }
        PlayerPrefs.SetInt("value", value);
    }
}