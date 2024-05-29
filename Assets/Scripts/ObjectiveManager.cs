using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveManager : MonoBehaviour
{
    public bool gameIsActive;
    public int numApplesOwned;
    public int numBananasOwned;
    public int numWatermelonsOwned;
    public int numOnionsOwned;
    public int numPotatosOwned;
    public int numCornOwned;
    public int numCheeseOwned;
    public int numEggsOwned;
    public int numMilkOwned;

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
    private QuestManager quest;

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
        numApplesOwned = 0;
        numBananasOwned = 0;
        numWatermelonsOwned = 0;
        numOnionsOwned = 0;
        numPotatosOwned = 0;
        numCornOwned = 0;
        numCheeseOwned = 0;
        numEggsOwned = 0;
        numMilkOwned = 0;
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
        if (numApplesOwned == quest.numApplesNeeded)
        {
            applesComplete = true;
        }
        else
        {
            applesComplete = false;
        }
        //bananas
        if (numBananasOwned == quest.numBananasNeeded)
        {
            bananasComplete = true;
        }
        else
        {
            bananasComplete = false;
        }
        //watermelon
        if (numWatermelonsOwned == quest.numWatermelonsNeeded)
        {
            WatermelonsComplete = true;
        }
        else
        {
            WatermelonsComplete = false;
        }

        //vegies
        ///onions
        if (numOnionsOwned == quest.numOnionsNeeded)
        {
            onionsComplete = true;
        }
        else
        {
            onionsComplete = false;
        }
        //potatos
        if (numPotatosOwned == quest.numPotatosNeeded)
        {
            potatosComplete = true;
        }
        else
        {
            potatosComplete = false;
        }
        //corn
        if (numCornOwned == quest.numCornNeeded)
        {
            cornComplete = true;
        }
        else
        {
            cornComplete = false;
        }

        //produce
        ///cheese
        if (numCheeseOwned == quest.numCheeseNeeded)
        {
            cheeseComplete = true;
        }
        else
        {
            cheeseComplete = false;
        }
        //eggs
        if (numEggsOwned == quest.numEggsNeeded)
        {
            eggsComplete = true;
        }
        else
        {
            eggsComplete = false;
        }
        //milk
        if (numMilkOwned == quest.numMilkNeeded)
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
