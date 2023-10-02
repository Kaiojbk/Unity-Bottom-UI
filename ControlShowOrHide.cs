using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlShowOrHide : MonoBehaviour
{
    public static bool isShow;
    public static bool isHide;

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            isShow = true;
            isHide = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        isHide = true;
        isShow = false;
    }

}
