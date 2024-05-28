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

    private InputManager input;
    public bool inUI;
    public bool mapIsEnabled;
    public bool pauseIsEnabled;
    public bool objectiveIsEnalbed;

    public void Start()
    {
        input = GetComponent<InputManager>();
        inUI = true;
    }
    public void UpdateText(string promptMessage)
    {
        promptText.text = promptMessage;
    }

    public void Update()
    {
        input.inUI = inUI;
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
        OpenPhone();
        HideCursor();
        inUI = false;
        phoneInProgress.SetActive(true);
    }
    public void phoneMapClose()
    {
        ClosePhone();
        HideCursor();
        inUI = false;
        phoneInProgress.SetActive(true);
    }

    public void OpenObjective()
    {
        OpenPhone();
        HideCursor();
        inUI = false;
        phoneObjective.SetActive(true);
    }
    public void CloseObjective()
    {
        ClosePhone();
        HideCursor();
        inUI = false;
        phoneObjective.SetActive(false);
    }
    public void Pause()
    {
        OpenPhone();
        ShowCursor();
        inUI = true;
        phonePause.SetActive(true);
        resumeButton.SetActive(true);
        helpButton.SetActive(true);
        quitButton.SetActive(true);
    }
    public void UnPause()
    {
        ClosePhone();
        HideCursor();
        inUI = false;
        phonePause.SetActive(false);
        resumeButton.SetActive(false);
        helpButton.SetActive(false);
        quitButton.SetActive(false);
    }

    public void StartMenu()
    {
        OpenPhone();
        phoneInProgress.SetActive(true);
        phoneObjective.SetActive(false);
        phonePause.SetActive(false);
        resumeButton.SetActive(false);
        helpButton.SetActive(false);
        quitButton.SetActive(false);
        ShowCursor();
        inUI = true;
        phoneStart.SetActive(true);
        clockInButton.SetActive(true);
    }
    public void CloseStart()
    {
        ClosePhone();
        HideCursor();
        inUI = false;
        phoneStart.SetActive(false);
        clockInButton.SetActive(false);
    }

    public void ToggleMap()
    {
        HideCursor();
        if (mapIsEnabled)
        {
            phoneMapOpen();
        }
        else
        {
            phoneMapClose();
        }
        mapIsEnabled = !mapIsEnabled;
    }

    public void TogglePause()
    {
        if (pauseIsEnabled)
        {
            Pause();
        }
        else
        {
            UnPause();
        }
        pauseIsEnabled = !pauseIsEnabled;
    }

    public void ToggleObjective()
    {
        if (objectiveIsEnalbed)
        {
            OpenObjective();
        }
        else
        {
            CloseObjective();
        }
        objectiveIsEnalbed = !objectiveIsEnalbed;
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
}
