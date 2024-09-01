using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : Character {

    [Header("Player Settings")]
    [SerializeField] private string playerName;

     private GameControls _controls;
     private Rigidbody2D _rb;

     private void Awake() {
        _controls = new GameControls();
        // _rb = GetComponent<Rigidbody2D>();

    }

    private void OnEnable()
    {
        _controls.Enable();

        // Move
        _controls.Player.Move.performed +=  handleMovePerformed;
        _controls.Player.Move.canceled +=  handleMoveCanceled;

        MovementSystem.onMovePropertiesUpdate += handleMoveProperties;
    }

    private void OnDisable()
    {
        _controls.Disable();

        // Move
        _controls.Player.Move.performed -= handleMovePerformed;
        _controls.Player.Move.canceled -= handleMoveCanceled;

        MovementSystem.onMovePropertiesUpdate -= handleMoveProperties;
    }

    private void FixedUpdate() {

        handleMove();
    }

    private void handleMovePerformed(InputAction.CallbackContext context)
    {
        Vector2 direction = _controls.Player.Move.ReadValue<Vector2>();
        MovementSystem.TriggerMovePerformed(direction);
    }

    private void handleMoveCanceled(InputAction.CallbackContext context)
    {
        MovementSystem.TriggerMoveCanceled();
    }


    public void handleMove() {
        if (moveProperties.direction == null) return;

        if(moveProperties.direction != Vector2.zero) {
            MovementSystem.TriggerForceApplied();
        }else {
            MovementSystem.TriggerForceRemoved();
        }
     }

     private void handleMoveProperties(MoveProperties move) {
        MovementSystem.TriggerMovePropertiesUpdate(move);
     }



}