using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class WebGLUtils : MonoBehaviour
{
    #region Variables
    #region DllImport
    [DllImport("__Internal")]
    private static extern void CallJS(int number);
    #endregion
    public void Start()
    {
        //Debug.Log("WebGLUtils Initialized");
    }
    public void CallJSMethod(int number)
    {
        CallJS(number);
    }
    #endregion
}
