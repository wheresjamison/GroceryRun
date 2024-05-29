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
                objective.numApplesOwned += 1;
                break;
            case "Banana":
                objective.numBananasOwned += 1;
                break;
            case "Watermelon":
                objective.numWatermelonsOwned += 1;
                break;
            case "Onion":
                objective.numOnionsOwned += 1;
                break;
            case "Potato":
                objective.numPotatosOwned += 1;
                break;
            case "Corn":
                objective.numCornOwned += 1;
                break;
            case "Egg":
                objective.numEggsOwned += 1;
                break;
            case "Cheese":
                objective.numCheeseOwned += 1;
                break;
            case "Milk":
                objective.numMilkOwned += 1;
                break;
            default:
                break;
        }
    }
}
