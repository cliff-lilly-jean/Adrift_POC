using UnityEngine;


public class PlayerController : MonoBehaviour {

    private GameControls _controls;
    [SerializeField] private Player _player;
    private Rigidbody2D _rb;

    private void Awake() {
        _controls = new GameControls();
        _player = GetComponent<Player>();
        _rb = GetComponent<Rigidbody2D>();
    }


    private void Update() {

        Debug.Log(_player);
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
        // _controls.Player.Move.performed += _ => _player.move.getMoveDirection(_player.direction);
        // _controls.Player.Move.canceled += _ => _player.move.resetMoveDirection(_player.direction);
    }

    private void OnDisable()
    {
        _controls.Disable();

        // Move
        // _controls.Player.Move.performed -= _ => _player.move.getMoveDirection(_player.direction);
        // _controls.Player.Move.canceled -= _ => _player.move.resetMoveDirection(_player.direction);
    }

    private void getInputDirection(Entity entity) {
       entity.direction = _controls.Player.Move.ReadValue<Vector2>();
    }

    public void handleMove() {


        if (_player.direction == null) return;

        // if(_player.direction != Vector2.zero) {
        //     _player.move.accelerate(_rb, _player.direction, _player._stats.speed);
        // }else {
        //     _player.move.decelerate(_rb);
        // }
    }
}