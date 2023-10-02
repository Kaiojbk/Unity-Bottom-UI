using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GetValue : MonoBehaviour
{
    public Scrollbar Scrollbar;
    TMP_Text speak;
    const float readSpeed = 6f;
    private void Start()
    {
        speak = GetComponent<TMP_Text>();
        
    }

    public IEnumerator Print(string Text)
    {
        speak.text = "";
        foreach (char value in Text)
        {
            speak.text += value;
            Scrollbar.value = 0f;
            yield return new WaitForSeconds(1f / readSpeed);
        }
    }
}
