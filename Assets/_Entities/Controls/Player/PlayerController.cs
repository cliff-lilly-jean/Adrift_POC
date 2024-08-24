using UnityEngine;

public class PlayerController : MonoBehaviour {

    private GameControls _controls;
    [SerializeField] private Player _player;

    private void Awake() {
        _controls = new GameControls();
        _player = GetComponent<Player>();

        // if (_player._abilities)
    }

    private void Update() {

        // Get all the abilities
        foreach (var ability in _player._abilities) {
            Debug.Log("Ability " + ability);
        }

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