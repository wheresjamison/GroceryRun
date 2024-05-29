using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableItem : Interactable
{

    public GameObject item;
    private ObjectiveManager objective;

    public void Start()
    {
        objective = FindAnyObjectByType<ObjectiveManager>();
    }

    protected override void Interact()
    {
        //same as door example
        Debug.Log("Interacted with " + item.name);

        AddItemToInventory(item.name);
        Debug.Log(item.name + " added to inventory");
    }

    public void AddItemToInventory(string name)
    {
        objective.incrementInventoryItem(name);
    }
}
