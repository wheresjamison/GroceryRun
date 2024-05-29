using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int yourScore;
    public bool gameIsActive;
    public string[] winText;
    public string winTextReturned;
    private PlayerUI ui;
    private Checker checker;

    //for IO reader
    /// <summary>
    /// this is for the status screen
    /// </summary>
    public string[] statusArray;
    public string status;
    ///
    //for IO reader

    void Start()
    {
        ui = FindAnyObjectByType<PlayerUI>();
        checker = FindAnyObjectByType<Checker>();
        winText = new string[] { "", "Perfect Run! Great Delivery", "Nice Try! Incorrect submission", "Pathetic Delivery! Nothing was right!" };
        statusArray = new string[] { "", "Jamison has recieved your order", "Jamison is Shopping for you", "Jamison is on his way", "Jamison has Delivered", "Jamison has given up" };
    }

    void Update()
    {
        if (gameIsActive)
        {
            ui.CloseTopScreenUI();
            ui.OpenHelpUI();
            yourScore = 0;
            ui.winText.text = winText[0];
        }
        else
        {
            ui.OpenTopScreenUI();
            ui.CloseHelpUI();
            yourScore = checker.currentScore;
            ui.scoreNumber.text = yourScore.ToString();
            ui.winText.text = winText[checker.index];
        }
    }

    public void Recieved()
    {
        status = statusArray[1];
        Debug.Log(status);
    }
    public void Shopping()
    {
        status = statusArray[2];
        Debug.Log(status);
    }
    public void OTW()
    {
        status = statusArray[3];
        Debug.Log(status);
    }
    public void Delivered()
    {
        status = statusArray[4];
        Debug.Log(status);
    }
    public void GivenUp()
    {
        status = statusArray[5];
        Debug.Log(status);
    }
}
