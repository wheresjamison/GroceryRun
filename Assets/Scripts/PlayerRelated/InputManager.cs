using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private PlayerInput playerInput;
    public PlayerInput.OnFootActions onFoot;
    
    private PlayerMotor motor;
    private PlayerLook look;
    private PlayerUI ui;

    // Start is called before the first frame update
    void Awake()
    {
        playerInput = new PlayerInput();
        onFoot = playerInput.OnFoot;
        motor = GetComponent<PlayerMotor>();
        look = GetComponent<PlayerLook>();
        ui = GetComponent<PlayerUI>();
        onFoot.Jump.performed += ctx => motor.Jump();
        onFoot.Map.performed += ctx => motor.ToggleMap();
        onFoot.Inventory.performed += ctx => motor.ToggleInventory();
        onFoot.Quest.performed += ctx => motor.ToggleQuest();

        //learn events, this is the syntax for events

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //tell playermotor to move using the input from player action
        motor.ProcessMove(onFoot.Movement.ReadValue<Vector2>());
    }

    private void LateUpdate()
    {
        look.ProcessLook(onFoot.Look.ReadValue<Vector2>());
    }

    private void OnEnable()
    {
        onFoot.Enable();
    }
    private void onDisable()
    {
        onFoot.Disable();
    }
}
