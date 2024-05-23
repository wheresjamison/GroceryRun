using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{

    private PlayerMotor motor;
    private PlayerUI ui;
    private ObjectiveManager objective;
    private QuestManager quest;

    public void Start()
    {
        motor = GetComponent<PlayerMotor>();
        ui = GetComponent<PlayerUI>();
        objective = GetComponent<ObjectiveManager>();
        quest = GetComponent<QuestManager>();
    }

    public void StartUpSequence()
    {
        //objective numbers are reset when the game is on start
        ui.StartMenu();
        objective.SetAllToFalse();
        objective.SetAllToZero();
        ui.ShowCursor();
        Debug.Log("Game has been started");
    }

    public void StartGame()
    {
        //closes the start menu and assigs house and location
        ui.HideCursor();
        ui.CloseStart();
        ui.ClosePhone();
        quest.GenerateHouse();
        quest.GenerateOrder();
        Debug.Log("StartGame has been pressed");
    }

    public void Resume()
    {
        //closes pause menu
        ui.HideCursor();
        ui.UnPause();
        ui.ClosePhone();
        Debug.Log("Resume has been pressed");
    }

    public void Help()
    {
        //opens help menu, will describe the game.
        Debug.Log("Help has been pressed");
        //opens the control menu and a description of the game. 
    }

    public void Quit()
    {
        //closes the clears quests and stuff. brings back to start menu
        ui.StartMenu();
        quest.ResetItemsNeededToZero();
        objective.SetAllToFalse();
        objective.SetAllToZero();
        Debug.Log("Quit has been pressed");
    }
}
