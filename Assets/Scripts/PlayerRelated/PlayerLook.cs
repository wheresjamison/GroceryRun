using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{

    public Camera cam;
    public float xRotation = 0f;

    public float xSensitivity = .5f;
    public float ySensitivity = .5f;

    public void ProcessLook(Vector2 input)
    {
        float mouseX = input.x;
        float mouseY = input.y;
        //camera rotation
        xRotation -= (mouseY * Time.deltaTime) * ySensitivity;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);
        //apply to camera transform
        cam.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        //rotate L Rs
        transform.Rotate(Vector3.up * (mouseX * Time.deltaTime) * xSensitivity);
    }
}
