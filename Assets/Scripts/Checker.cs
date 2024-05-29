using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Checker : MonoBehaviour
{
    private QuestManager quest;
    private ObjectiveManager objective;
    public bool correctDoor;
    public bool correctOrder;
    public int doorIndex;
    public int currentScore;
    public int index;
    private GameManager game;

    public void Start()
    {
        quest = FindAnyObjectByType<QuestManager>();
        objective = FindAnyObjectByType<ObjectiveManager>();
        game = FindAnyObjectByType<GameManager>();
        currentScore = 0;
    }

    public void Update()
    {

    }

    public void CheckWin()
    {
        CheckIfCorrectDoor();
        CheckOrder();
        if (correctDoor && correctOrder)
        {
            index = 1;
        }
        else if (!correctDoor && correctOrder)
        {
            index = 2;
        }
        else if (correctDoor && !correctOrder)
        {
            index = 2;
        }
        else
        {
            index = 3;
        }
        game.gameIsActive = false;
    }


    public void CheckIfCorrectDoor()
    {
        if (quest.assignedAddressIndex == doorIndex)
        {
            correctDoor = true;
        }
    }

    public void CheckOrder()
    {
        int x = 10;
        if (objective.numApplesOwned == quest.numApplesNeeded)
        {
            x += 0;
        }
        else
        {
            x -= 1;
        }
        if (objective.numBananasOwned == quest.numBananasNeeded)
        {
            x += 0;
        }
        else
        {
            x -= 1;
        }
        if (objective.numWatermelonsOwned == quest.numWatermelonsNeeded)
        {
            x += 0;
        }
        else
        {
            x -= 1;
        }
        if (objective.numOnionsOwned == quest.numOnionsNeeded)
        {
            x += 0;
        }
        else
        {
            x -= 1;
        }
        if (objective.numPotatosOwned == quest.numPotatosNeeded)
        {
            x += 0;
        }
        else
        {
            x -= 1;
        }
        if (objective.numCornOwned == quest.numCornNeeded)
        {
            x += 0;
        }
        else
        {
            x -= 1;
        }
        if (objective.numEggsOwned == quest.numEggsNeeded)
        {
            x += 0;
        }
        else
        {
            x -= 1;
        }
        if (objective.numMilkOwned == quest.numMilkNeeded)
        {
            x += 0;
        }
        else
        {
            x -= 1;
        }
        if (objective.numCheeseOwned == quest.numCheeseNeeded)
        {
            x += 0;
        }
        else
        {
            x -= 1;
        }
        //this is the win lost and grey
        if (x == 10)
        {
            correctOrder = true;
            currentScore = 10;
        }
        else if (x == 0)
        {
            correctOrder = false;
        }
        else
        {
            correctOrder = true;
            currentScore = x;
        }
    }
}
