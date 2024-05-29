using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestGiver : MonoBehaviour
{
    public Quest quest;
    public GameObject player;

    public GameObject questWindow;
    public Text titleText;
    public Text descriptionText;
    public Text timeGoal;
    public Text cashReward;

    public void OpenQuestWindow()
    {
        questWindow.SetActive(true);
        titleText.text = quest.title;
        timeGoal.text = quest.timeGoal.ToString();
        cashReward.text = quest.cashReward.ToString();
    }

    public void AcceptQuest()
    {
        questWindow.SetActive(false);
        quest.isActive = true;
        //give to player

    }
}
