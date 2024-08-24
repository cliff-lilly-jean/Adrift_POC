using UnityEngine;

public class PlayerController : MonoBehaviour {

    private GameControls _controls;
    private Player _player;

    private void Awake() {
        _controls = new GameControls();
        // _rb = GetComponentInChildren<Rigidbody2D>();
    }

     private void OnEnable()
    {
        _controls.Enable();

        // // Move
        // _controls.Player.Move.performed += _ => move.getMoveDirection(_character._stats.direction);
        // _controls.Player.Move.canceled += _ => move.resetMoveDirection(_character._stats.direction);
    }

    private void OnDisable()
    {
        _controls.Disable();

        // // Move
        // _controls.Player.Move.performed -= _ => move.getMoveDirection(_character._stats.direction);
        // _controls.Player.Move.canceled -= _ => move.resetMoveDirection(_character._stats.direction);
    }
}