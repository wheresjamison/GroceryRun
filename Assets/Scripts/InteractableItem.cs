using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableItem : Interactable
{

    public GameObject item;
    private ObjectiveManager objective;
    private GameManager game;

    public void Start()
    {
        objective = FindAnyObjectByType<ObjectiveManager>();
        game = FindAnyObjectByType<GameManager>();
    }

    protected override void Interact()
    {
        //same as door example
        Debug.Log("Interacted with " + item.name);

        AddItemToInventory(item.name);
        Debug.Log(item.name + " added to inventory");
        game.Shopping();
    }

    public void AddItemToInventory(string name)
    {
        objective.incrementInventoryItem(name);
    }
}
