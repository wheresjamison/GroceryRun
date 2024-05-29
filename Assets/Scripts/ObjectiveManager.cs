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

    public string address;
    public string apples;
    public string bananas;
    public string watermelons;
    public string onions;
    public string potatos;
    public string corns;
    public string cheeses;
    public string eggs;
    public string milks;

    // public bool applesComplete;
    // public bool bananasComplete;
    // public bool WatermelonsComplete;
    // public bool onionsComplete;
    // public bool potatosComplete;
    // public bool cornComplete;
    // public bool cheeseComplete;
    // public bool eggsComplete;
    // public bool milkComplete;
    // public bool orderIsReadyForDelivery;
    // public bool correctHouse;
    // public bool win;
    private QuestManager quest;

    // Start is called before the first frame update
    void Start()
    {
        //orderIsReadyForDelivery = false;
        gameIsActive = true;
        address = "filler";
        apples = "0";
        bananas = "0";
        watermelons = "0";
        onions = "0";
        potatos = "0";
        corns = "0";
        eggs = "0";
        milks = "0";
        cheeses = "0";
        SetAllToZero();
    }

    // Update is called once per frame
    void Update()
    {
        //CheckIfOrderIsMet();
    }

    public void incrementInventoryItem(string name)
    {
        switch (name)
        {
            case "Apple":
                numApplesOwned += 1;
                break;
            case "Banana":
                numBananasOwned += 1;
                break;
            case "Watermelon":
                numWatermelonsOwned += 1;
                break;
            case "Onion":
                numOnionsOwned += 1;
                break;
            case "Potato":
                numPotatosOwned += 1;
                break;
            case "Corn":
                numCornOwned += 1;
                break;
            case "Egg":
                numEggsOwned += 1;
                break;
            case "Cheese":
                numCheeseOwned += 1;
                break;
            case "Milk":
                numMilkOwned += 1;
                break;
            default:
                break;
        }
        convertToString();
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
        convertToString();
    }
    public void convertToString()
    {
        apples = numApplesOwned.ToString();
        bananas = numBananasOwned.ToString();
        watermelons = numWatermelonsOwned.ToString();
        onions = numOnionsOwned.ToString();
        potatos = numPotatosOwned.ToString();
        corns = numCornOwned.ToString();
        eggs = numEggsOwned.ToString();
        milks = numMilkOwned.ToString();
        cheeses = numCheeseOwned.ToString();
    }


    // public void SetAllToFalse()
    // {
    //     applesComplete = false;
    //     bananasComplete = false;
    //     WatermelonsComplete = false;
    //     onionsComplete = false;
    //     potatosComplete = false;
    //     cornComplete = false;
    //     cheeseComplete = false;
    //     eggsComplete = false;
    //     milkComplete = false;
    // }

    // public void CheckIfOrderIsMet()
    // {
    //     ///apples
    //     if (numApplesOwned == quest.numApplesNeeded)
    //     {
    //         applesComplete = true;
    //     }
    //     else
    //     {
    //         applesComplete = false;
    //     }
    //     //bananas
    //     if (numBananasOwned == quest.numBananasNeeded)
    //     {
    //         bananasComplete = true;
    //     }
    //     else
    //     {
    //         bananasComplete = false;
    //     }
    //     //watermelon
    //     if (numWatermelonsOwned == quest.numWatermelonsNeeded)
    //     {
    //         WatermelonsComplete = true;
    //     }
    //     else
    //     {
    //         WatermelonsComplete = false;
    //     }

    //     //vegies
    //     ///onions
    //     if (numOnionsOwned == quest.numOnionsNeeded)
    //     {
    //         onionsComplete = true;
    //     }
    //     else
    //     {
    //         onionsComplete = false;
    //     }
    //     //potatos
    //     if (numPotatosOwned == quest.numPotatosNeeded)
    //     {
    //         potatosComplete = true;
    //     }
    //     else
    //     {
    //         potatosComplete = false;
    //     }
    //     //corn
    //     if (numCornOwned == quest.numCornNeeded)
    //     {
    //         cornComplete = true;
    //     }
    //     else
    //     {
    //         cornComplete = false;
    //     }

    //     //produce
    //     ///cheese
    //     if (numCheeseOwned == quest.numCheeseNeeded)
    //     {
    //         cheeseComplete = true;
    //     }
    //     else
    //     {
    //         cheeseComplete = false;
    //     }
    //     //eggs
    //     if (numEggsOwned == quest.numEggsNeeded)
    //     {
    //         eggsComplete = true;
    //     }
    //     else
    //     {
    //         eggsComplete = false;
    //     }
    //     //milk
    //     if (numMilkOwned == quest.numMilkNeeded)
    //     {
    //         milkComplete = true;
    //     }
    //     else
    //     {
    //         milkComplete = false;
    //     }

    //     if (
    //         applesComplete &&
    //         bananasComplete &&
    //         WatermelonsComplete &&
    //         onionsComplete &&
    //         potatosComplete &&
    //         cornComplete &&
    //         cheeseComplete &&
    //         eggsComplete &&
    //         milkComplete
    //         )
    //     {
    //         orderIsReadyForDelivery = true;
    //     }
    //     else
    //     {
    //         orderIsReadyForDelivery = false;
    //     }
    // }
    // public void CheckHouse(int houseNumber)
    // {
    //     if (houseNumber == quest.assignedAddressIndex)
    //     {
    //         correctHouse = true;
    //         Debug.Log("Correct House");
    //     }
    //     else
    //     {
    //         correctHouse = false;
    //         Debug.Log("Incorrect House");
    //     }
    // }
    // public void DeliverToCustomer()
    // {
    //     if (correctHouse)
    //     {
    //         win = true;
    //         Debug.Log("You have won");
    //         //pause time and give player reward.
    //     }
    // }
}
