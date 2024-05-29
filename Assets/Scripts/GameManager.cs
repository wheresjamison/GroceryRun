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
    void Start()
    {
        ui = FindAnyObjectByType<PlayerUI>();
        checker = FindAnyObjectByType<Checker>();
        winText = new string[] { "", "Perfect Run! Great Delivery", "Nice Try! Incorrect submission", "Pathetic Delivery! Nothing was right!" };
    }

    void Update()
    {
        if (gameIsActive)
        {
            ui.topScreen.SetActive(false);
            ui.helpUI.SetActive(true);
            yourScore = 0;
            ui.winText.text = winText[0];

        }
        else
        {
            ui.topScreen.SetActive(true);
            ui.helpUI.SetActive(false);
            yourScore = checker.currentScore;
            ui.scoreNumber.text = yourScore.ToString();
            ui.winText.text = winText[checker.index];
        }
    }
}
