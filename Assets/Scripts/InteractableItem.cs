using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableItem : Interactable
{

    public GameObject item;
    private ObjectiveManager objective;

    protected override void Interact()
    {
        //same as door example
        Debug.Log("Interacted with " + gameObject.name);

        AddItemToInventory(item.name);
        Debug.Log(gameObject.name + " added to inventory");
    }

    public void AddItemToInventory(string name)
    {
        switch (name)
        {
            case "Apple":
                objective.numApples += 1;
                break;
            case "Banana":
                objective.numBananas += 1;
                break;
            case "Watermelon":
                objective.numWatermelons += 1;
                break;
            case "Onion":
                objective.numOnions += 1;
                break;
            case "Potato":
                objective.numPotatos += 1;
                break;
            case "Corn":
                objective.numCorn += 1;
                break;
            case "Egg":
                objective.numEggs += 1;
                break;
            case "Cheese":
                objective.numCheese += 1;
                break;
            case "Milk":
                objective.numMilk += 1;
                break;
            default:
                break;
        }
    }
}
