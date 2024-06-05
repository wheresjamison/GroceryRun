using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberSender : MonoBehaviour
{
    //private WebGLUtils wglu;
    public void Start()
    {
        // wglu = FindAnyObjectByType<WebGLUtils>();
        // Debug.Log("NumberSender script has started.");
    }
    public void SenderNumberToJS(int number)
    {
        if (Application.platform == RuntimePlatform.WebGLPlayer)
        {
            //wglu.CallJSMethod(number);
        }
        //wglu.CallJSMethod(number);
    }
}
