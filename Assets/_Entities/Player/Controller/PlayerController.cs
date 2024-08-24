using UnityEngine;
using Adrift.Utilities.Abilities.Movement;

public class PlayerController : MonoBehaviour {

    private GameControls _controls;
    [SerializeField] private Player _player;

    private void Awake() {
        _controls = new GameControls();
        _player = GetComponent<Player>();
    }


    private void Update() {


        // Get all the abilities
        foreach (var ability in _player._abilities) {
            Debug.Log("Ability " + ability);
        }

        Debug.Log(Movement.getMoveDirection(Vector2.down));
    }

     private void FixedUpdate() {

        // Connect direction to the read value of the controls
        getInputDirection(_player);
        handleMove();

    }


     private void OnEnable()
    {
        _controls.Enable();

        // Move
        _controls.Player.Move.performed += _ => Movement.getMoveDirection(_player.direction);
        _controls.Player.Move.canceled += _ => Movement.resetMoveDirection(_player.direction);
    }

    private void OnDisable()
    {
        _controls.Disable();

        // Move
        _controls.Player.Move.performed -= _ => Movement.getMoveDirection(_player.direction);
        _controls.Player.Move.canceled -= _ => Movement.resetMoveDirection(_player.direction);
    }

    private void getInputDirection(Entity entity) {
       entity.direction = _controls.Player.Move.ReadValue<Vector2>();
    }

    public void handleMove() {

        var deceleration = 2f;
        var force = 10f;


        if (_player.direction == null) return;

        if(_player.direction != Vector2.zero) {
            Movement.accelerate(_player._rb, _player.direction, _player._stats.speed, force);
        }else {
            Movement.decelerate(_player._rb, deceleration, force);
        }
    }
}