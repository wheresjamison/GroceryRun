using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{

    private CharacterController controller;
    private Vector3 playerVelocity;
    public float speed = 5f;
    private bool isGrounded;
    public float gravity = -9.8f;
    public float jumpHeight = 3f;

    //ui related
    private PlayerUI ui;
    public bool mapIsEnabled;
    public bool inventoryIsEnabled;
    public bool questIsEnabled;


    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        ui = GetComponent<PlayerUI>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = controller.isGrounded;
    }
    public void ProcessMove(Vector2 input)
    {
        Vector3 moveDirection = Vector3.zero;
        moveDirection.x = input.x;
        moveDirection.z = input.y;
        controller.Move(transform.TransformDirection(moveDirection) * speed * Time.deltaTime);
        playerVelocity.y += gravity * Time.deltaTime;
        if (isGrounded && playerVelocity.y < 0)
        {
            playerVelocity.y = -2f;
        }
       
        controller.Move(playerVelocity * Time.deltaTime);
    }

    public void Jump()
    {
        if (isGrounded)
        {
            playerVelocity.y = Mathf.Sqrt(jumpHeight * -3.0f * gravity);
        }
    }

    public void ToggleInventory()
    {
        if (inventoryIsEnabled)
        {
            ui.OpenInventory();
        }
        else
        {
            ui.CloseInventory();
        }
        inventoryIsEnabled = !inventoryIsEnabled;
    }

    public void ToggleMap()
    {
        if (mapIsEnabled)
        {
            ui.OpenMinimap();
        }
        else
        {
            ui.CloseMinimap();
        }
        mapIsEnabled = !mapIsEnabled;
    }

    public void ToggleQuest()
    {
        if (questIsEnabled)
        {
            ui.OpenQuest();
        }
        else
        {
            ui.CloseQuest();
        }
        questIsEnabled = !questIsEnabled;
    }
}
