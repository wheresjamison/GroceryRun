using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI promptText;
    [SerializeField] public GameObject phone;
    [SerializeField] public GameObject phoneInProgress;
    [SerializeField] public GameObject phoneObjective;

    [SerializeField] public GameObject phonePause;
    [SerializeField] public GameObject resumeButton;
    [SerializeField] public GameObject helpButton;
    [SerializeField] public GameObject quitButton;

    [SerializeField] public GameObject phoneStart;
    [SerializeField] public GameObject clockInButton;

    public bool inUI;

    public void start()
    {
        inUI = true;
    }

    public void UpdateText(string promptMessage)
    {
        promptText.text = promptMessage;
    }

    public void OpenPhone()
    {
        phone.SetActive(true);
    }
    public void ClosePhone()
    {
        phone.SetActive(false);
    }

    public void phoneMapOpen()
    {
        phoneInProgress.SetActive(true);
    }
    public void phoneMapClose()
    {
        phoneInProgress.SetActive(true);
    }

    public void OpenObjective()
    {
        phoneObjective.SetActive(true);
    }
    public void CloseObjective()
    {
        phoneObjective.SetActive(false);
    }
    public void Pause()
    {
        phonePause.SetActive(true);
        resumeButton.SetActive(true);
        helpButton.SetActive(true);
        quitButton.SetActive(true);
    }
    public void UnPause()
    {
        phonePause.SetActive(false);
        resumeButton.SetActive(false);
        helpButton.SetActive(false);
        quitButton.SetActive(false);
    }

    public void StartMenu()
    {
        phoneStart.SetActive(true);
        clockInButton.SetActive(true);
    }
    public void CloseStart()
    {
        phoneStart.SetActive(false);
        clockInButton.SetActive(false);
    }

    public void ShowCursor()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void HideCursor()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    //inUI = false;     

}
