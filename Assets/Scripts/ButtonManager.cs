using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    private PlayerUI ui;
    private ObjectiveManager objective;
    private QuestManager quest;
    private GameManager game;

    public void Start()
    {
        ui = GetComponent<PlayerUI>();
        objective = GetComponent<ObjectiveManager>();
        quest = GetComponent<QuestManager>();
        game = FindAnyObjectByType<GameManager>();

        Debug.Log("UI, Objective, Quest : " + ui + " " + objective + " " + quest + ".");
    }

    public void StartUpSequence()
    {
        //objective numbers are reset when the game is on start
        ui.StartMenu();
        //objective.SetAllToFalse();
        objective.SetAllToZero();
        Debug.Log("Game has been started");
    }

    public void StartGame()
    {
        //closes the start menu and assigs house and location
        ui.CloseStart(); // <------------------------------------------- look here ----- ERROR OCCURS HERE FOR NULLEXCEPTION . I cant get this to fucking work 
        game.Recieved();
        quest.GenerateHouse();
        quest.GenerateOrder();
        Debug.Log("StartGame has been pressed");
    }

    public void Resume()
    {
        //closes pause menu
        ui.UnPause();
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
        Debug.Log("Quit has been pressed");
        game.GivenUp();
    }
}
