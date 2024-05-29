using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

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
        statusArray = new string[] { "Jamison has Arrived at the store", "Jamison has recieved your order", "Jamison is Shopping for you", "Jamison is on his way", "Jamison has Delivered", "Jamison has given up" };
    }

    void Update()
    {
        if (gameIsActive)
        {
            ui.CloseTopScreenUI();
            yourScore = 0;
            ui.winText.text = winText[0];
        }
        else
        {
            ui.OpenTopScreenUI();
            yourScore = checker.currentScore;
            ui.scoreNumber.text = yourScore.ToString();
            ui.winText.text = winText[checker.index];
        }
    }


    void CreateText()
    {
        string path = Application.dataPath + "/ioComm.txt";
        if (!File.Exists(path))
        {
            File.WriteAllText(path, "IOWriter \n\n");
        }
        string content = "GroceryRun: " + status + "\n";
        File.AppendAllText(path, content);
    }
    public void Recieved()
    {
        status = statusArray[1];
        Debug.Log(status);
        CreateText();
    }
    public void AtStore()
    {
        status = statusArray[0];
        Debug.Log(status);
        CreateText();
    }
    public void Shopping()
    {
        status = statusArray[2];
        Debug.Log(status);
        CreateText();
    }
    public void OTW()
    {
        status = statusArray[3];
        Debug.Log(status);
        CreateText();
    }
    public void Delivered()
    {
        status = statusArray[4];
        Debug.Log(status);
        CreateText();
    }
    public void GivenUp()
    {
        status = statusArray[5];
        Debug.Log(status);
        CreateText();
    }
}
