using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI promptText;
    [SerializeField] public GameObject phone;
    [SerializeField] public GameObject phoneInProgress;
    //this is the inventory
    [SerializeField] public GameObject phoneInventoryObjective;
    [SerializeField] public GameObject phoneQuestObjective; // new

    [SerializeField] public GameObject phonePause;
    [SerializeField] public GameObject resumeButton;
    [SerializeField] public GameObject helpButton;
    [SerializeField] public GameObject quitButton;

    [SerializeField] public GameObject phoneStart;
    [SerializeField] public GameObject clockInButton;

    private InputManager input;
    public bool inUI;
    public bool startIsEnabled;
    public bool mapIsEnabled;
    public bool pauseIsEnabled;
    public bool inventoryObjectiveIsEnalbed;
    public bool questObjectiveIsEnabled;
    public int uiPage;

    [SerializeField] public TextMeshProUGUI addressTextInInventory;
    [SerializeField] public TextMeshProUGUI numApplesInInventory;
    [SerializeField] public TextMeshProUGUI numBananasInInventory;
    [SerializeField] public TextMeshProUGUI numWatermelonsInInventory;
    [SerializeField] public TextMeshProUGUI numOnionsInInventory;
    [SerializeField] public TextMeshProUGUI numPotatosInInventory;
    [SerializeField] public TextMeshProUGUI numCornInInventory;
    [SerializeField] public TextMeshProUGUI numEggsInInventory;
    [SerializeField] public TextMeshProUGUI numMilkInInventory;
    [SerializeField] public TextMeshProUGUI numCheeseInInventory;

    [SerializeField] public TextMeshProUGUI scoreText;
    [SerializeField] public TextMeshProUGUI scoreNumber;
    [SerializeField] public TextMeshProUGUI winText;
    [SerializeField] public GameObject topScreen;
    [SerializeField] public GameObject helpUI;
    private GameManager game;

    public void Start()
    {
        input = GetComponent<InputManager>();
        game = FindAnyObjectByType<GameManager>();
        inUI = true;
        uiPage = 0;
        StartMenu();
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

    public void OpenMap()
    {
        OpenPhone();
        HideCursor();
        inUI = false;
        phoneInProgress.SetActive(true);
    }
    public void CloseMap()
    {
        ClosePhone();
        HideCursor();
        inUI = false;
        phoneInProgress.SetActive(true);
    }

    public void OpenInventoryObjective()
    {
        OpenPhone();
        HideCursor();
        inUI = false;
        phoneInventoryObjective.SetActive(true);
    }
    public void CloseInventoryObjective()
    {
        ClosePhone();
        HideCursor();
        inUI = false;
        phoneInventoryObjective.SetActive(false);
    }
    public void OpenQuestObjective()
    {
        OpenPhone();
        HideCursor();
        inUI = false;
        phoneQuestObjective.SetActive(true);
    }
    public void CloseQuestObjective()
    {
        ClosePhone();
        HideCursor();
        inUI = false;
        phoneQuestObjective.SetActive(false);
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
        startIsEnabled = true;
        game.gameIsActive = false;
        OpenPhone();
        phoneInProgress.SetActive(true);
        phoneInventoryObjective.SetActive(false);
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
        startIsEnabled = false;
        game.gameIsActive = true;
        ClosePhone();
        HideCursor();
        inUI = false;
        phoneStart.SetActive(false);
        clockInButton.SetActive(false);
    }

    public void ToggleMap()
    {
        HideCursor();
        CloseInventoryObjective();
        CloseQuestObjective();
        if (mapIsEnabled)
        {
            OpenMap();

        }
        else
        {
            CloseMap();
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

    public void ToggleInventoryObjective()
    {
        HideCursor();
        CloseQuestObjective();
        CloseMap();
        if (inventoryObjectiveIsEnalbed)
        {
            OpenInventoryObjective();
        }
        else
        {
            CloseInventoryObjective();
        }
        inventoryObjectiveIsEnalbed = !inventoryObjectiveIsEnalbed;
    }
    public void ToggleQuestObjective()
    {
        HideCursor();
        CloseInventoryObjective();
        CloseMap();
        if (questObjectiveIsEnabled)
        {
            OpenQuestObjective();

        }
        else
        {
            CloseQuestObjective();
        }
        questObjectiveIsEnabled = !questObjectiveIsEnabled;
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

    public void FlipThroughUI()
    {
        switch (uiPage)
        {
            case 0:
                //MAP
                CloseInventoryObjective();
                OpenMap();
                uiPage = 1;
                Debug.Log("ToQst");
                break;
            case 1:
                //Quest
                CloseMap();
                OpenQuestObjective();
                uiPage = 2;
                Debug.Log("ToInv");
                break;
            case 2:
                //Inventory
                CloseQuestObjective();
                OpenInventoryObjective();
                uiPage = 0;
                Debug.Log("ToMap");
                break;
            default:
                uiPage = 0;
                OpenMap();
                break;
        }
    }
    public void CloseFlipUI()
    {
        CloseMap();
        CloseInventoryObjective();
        CloseQuestObjective();
    }
}
