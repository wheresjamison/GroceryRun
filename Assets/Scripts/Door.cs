using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : Interactable
{

    private ObjectiveManager objective;

    public GameObject door;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    protected override void Interact()
    {
        Debug.Log("Interacted with " + gameObject.name);
        //create function that submits the order to the customer's door

        // objective.CheckHouse(1);
        // objective.CheckIfOrderIsMet();
        // objective.DeliverToCustomer();

    }
}
