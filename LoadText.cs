using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Crosstales.RTVoice.Tool;

public class LoadText : MonoBehaviour
{
    public TextAsset textTest;          // ÎÄ±¾
    SpeechText say;
    public GameObject target;

    private void Start()
    {
        say = GameObject.Find("SpeechText").GetComponent<SpeechText>();
        //target = GameObject.Find("Canvas/Img_Introducion/Temp/Txt_Tips");
    }

    private void Update()
    {
        
    }

    void Speak(string text)
    {
        say.Text = text;
        say.Speak();
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            StartCoroutine(target.GetComponent<GetValue>().Print(textTest.text));
            //StartCoroutine(target.GetComponent<GetValue>().UnShake());
            Speak(textTest.text);
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        StopAllCoroutines();
        Speak("");
        target.GetComponent<TMP_Text>().text = "";
    }

    
}
