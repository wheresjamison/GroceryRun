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
    private PlayerUI ui;

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
        //Debug.Log("Process Move is moving the player");
    }

    public void Jump()
    {
        if (isGrounded)
        {
            playerVelocity.y = Mathf.Sqrt(jumpHeight * -3.0f * gravity);
        }
    }

    private bool mapIsEnabled;
    public void ToggleMap()
    {
        ui.HideCursor();
        if (mapIsEnabled)
        {
            ui.OpenPhone();
        }
        else
        {
            ui.ClosePhone();
        }
        mapIsEnabled = !mapIsEnabled;
    }

    private bool gamePaused;
    public void TogglePause()
    {
        if (gamePaused)
        {
            ui.OpenPhone();
            ui.Pause();
            ui.ShowCursor();
        }
        else
        {
            ui.HideCursor();
            ui.UnPause();
        }
        gamePaused = !gamePaused;
    }
    private bool objectiveIsEnalbed;
    public void ToggleObjective()
    {
        if (objectiveIsEnalbed)
        {
            ui.OpenPhone();
            ui.OpenObjective();
        }
        else
        {
            ui.CloseObjective();
            ui.ClosePhone();
        }
    }

    public void CloseStart()
    {
        ui.CloseStart();
        ui.ClosePhone();
        ui.HideCursor();
    }

    public void OpenStart()
    {
        ui.OpenPhone();
        ui.StartMenu();
        ui.ShowCursor();
    }

}
