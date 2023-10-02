using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlImg : MonoBehaviour
{
    CanvasGroup ctrl;
    [Range(0, 1)] public  float speed;
    void Start()
    {
        ctrl = GetComponent<CanvasGroup>();
    }

  
    void Update()
    {
        Show();
        Hide();
    }

    private void Show()
    {
        if(ControlShowOrHide.isShow)
        {
            ctrl.alpha += speed * Time.deltaTime;
        }
    }

    private void Hide()
    {
        if(ControlShowOrHide.isHide)
        {
            ctrl.alpha -= speed * Time.deltaTime;
        }
    }
}
