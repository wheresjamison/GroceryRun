using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveManager : MonoBehaviour
{
    public bool gameIsActive;

    public int numApples;
    public int numBananas;
    public int numWatermelons;
    public int numOnions;
    public int numPotatos;
    public int numCorn;
    public int numCheese;
    public int numEggs;
    public int numMilk;

    public bool applesComplete;
    public bool bananasComplete;
    public bool WatermelonsComplete;
    public bool onionsComplete;
    public bool potatosComplete;
    public bool cornComplete;
    public bool cheeseComplete;
    public bool eggsComplete;
    public bool milkComplete;

    public bool orderIsReadyForDelivery;
    public bool correctHouse;
    public bool win;

    public QuestManager quest;

    // Start is called before the first frame update
    void Start()
    {
        orderIsReadyForDelivery = false;
        gameIsActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        //checks to see if questmanager is met.
        if (quest.orderAssigned == true)
        {
            CheckIfOrderIsMet();
        }
        if (orderIsReadyForDelivery)
        {
            //generate text using UI
            //also call certain video for display.
            return;
        }
        //time to deliver to deliver to customer.

    }

    public void SetAllToZero()
    {
        numApples = 0;
        numBananas = 0;
        numWatermelons = 0;
        numOnions = 0;
        numPotatos = 0;
        numCorn = 0;
        numCheese = 0;
        numEggs = 0;
        numMilk = 0;
    }

    public void SetAllToFalse()
    {
        applesComplete = false;
        bananasComplete = false;
        WatermelonsComplete = false;
        onionsComplete = false;
        potatosComplete = false;
        cornComplete = false;
        cheeseComplete = false;
        eggsComplete = false;
        milkComplete = false;
    }

    public void CheckIfOrderIsMet()
    {
        ///apples
        if (numApples == quest.numApplesNeeded)
        {
            applesComplete = true;
        }
        else
        {
            applesComplete = false;
        }
        //bananas
        if (numBananas == quest.numBananasNeeded)
        {
            bananasComplete = true;
        }
        else
        {
            bananasComplete = false;
        }
        //watermelon
        if (numWatermelons == quest.numWatermelonsNeeded)
        {
            WatermelonsComplete = true;
        }
        else
        {
            WatermelonsComplete = false;
        }

        //vegies
        ///onions
        if (numOnions == quest.numOnionsNeeded)
        {
            onionsComplete = true;
        }
        else
        {
            onionsComplete = false;
        }
        //potatos
        if (numPotatos == quest.numPotatosNeeded)
        {
            potatosComplete = true;
        }
        else
        {
            potatosComplete = false;
        }
        //corn
        if (numCorn == quest.numCornNeeded)
        {
            cornComplete = true;
        }
        else
        {
            cornComplete = false;
        }

        //produce
        ///cheese
        if (numCheese == quest.numCheeseNeeded)
        {
            cheeseComplete = true;
        }
        else
        {
            cheeseComplete = false;
        }
        //eggs
        if (numEggs == quest.numEggsNeeded)
        {
            eggsComplete = true;
        }
        else
        {
            eggsComplete = false;
        }
        //milk
        if (numMilk == quest.numMilkNeeded)
        {
            milkComplete = true;
        }
        else
        {
            milkComplete = false;
        }

        if (
            applesComplete &&
            bananasComplete &&
            WatermelonsComplete &&
            onionsComplete &&
            potatosComplete &&
            cornComplete &&
            cheeseComplete &&
            eggsComplete &&
            milkComplete
            )
        {
            orderIsReadyForDelivery = true;
        }
        else
        {
            orderIsReadyForDelivery = false;
        }
    }

    //raycast no click
    public void CheckHouse(int houseNumber)
    {
        if (houseNumber == quest.assignedAddressIndex)
        {
            correctHouse = true;
            Debug.Log("Correct House");
        }
        else
        {
            correctHouse = false;
            Debug.Log("Incorrect House");
        }
    }
    public void DeliverToCustomer()
    {
        if (correctHouse)
        {
            win = true;
            Debug.Log("You have won");
            //pause time and give player reward.
        }
    }
}
