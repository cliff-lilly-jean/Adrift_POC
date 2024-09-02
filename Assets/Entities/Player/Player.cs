using UnityEngine;
using UnityEngine.InputSystem;

public class Player : Character {

    [Header("Player Settings")]
    [SerializeField] private string playerName;
    private Move move;

     private GameControls _controls;
     private Rigidbody2D _rb;

     private void Awake() {
        _controls = new GameControls();
        // _rb = GetComponent<Rigidbody2D>();

        move = GetComponent<Move>();

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

        move.handleMove();
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

     private void handleMoveProperties(MoveProperties move) {
        MovementSystem.TriggerMovePropertiesUpdate(move);
     }



}