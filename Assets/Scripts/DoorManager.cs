using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class DoorManager : Interactable
{
    public int doorIndex;
    [SerializeField] private GameObject door;
    private QuestManager quest;
    private Checker check;

    // Start is called before the first frame update
    void Start()
    {
        quest = FindAnyObjectByType<QuestManager>();
    }

    // Update is called once per frame
    void Update()
    {
        door.name = quest.addresses[doorIndex];
        promptMessage = "Submit order to :  " + door.name;
    }

    protected override void Interact()
    {
        Debug.Log("Interacted with " + door.name);
        Debug.Log("Door index is " + doorIndex);
        check.CheckWin();
    }
}
