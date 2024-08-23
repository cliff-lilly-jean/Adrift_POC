using UnityEngine;

public class PlayerController : CharacterController2D
{
    private GameControls _controls;
    private Rigidbody2D _rb;

    private void Awake() {
        _controls = new GameControls();
        _character = GetComponent<Character>();
        _rb = GetComponentInChildren<Rigidbody2D>();
    }

    private void OnEnable()
    {
        _controls.Enable();

        // Move
        _controls.Player.Move.performed += _ => move.getMoveDirection(_character._stats.direction);
        _controls.Player.Move.canceled += _ => move.resetMoveDirection(_character._stats.direction);
    }

    private void OnDisable()
    {
        _controls.Disable();

        // Move
        _controls.Player.Move.performed -= _ => move.getMoveDirection(_character._stats.direction);
        _controls.Player.Move.canceled -= _ => move.resetMoveDirection(_character._stats.direction);
    }

    private void FixedUpdate() {

        // Connect direction to the read value of the controls
        getInputDirection();

        if (move == null) {
            Debug.LogError("move is null!");
            return;
        }


        handleMove();

    }

    private void getInputDirection() {
       _character._stats.direction = _controls.Player.Move.ReadValue<Vector2>();
    }

    private void handleMove() {

        if (_character._stats.direction == null) return;

        if(_character._stats.direction != Vector2.zero) {
            move.accelerate(_rb, _character._stats.direction, _character._stats.acceleration, _character._stats.force, _character._stats.maxSpeed);
        }else {
            move.decelerate(_rb, _character._stats.deceleration, _character._stats.force);
        }


     }
}