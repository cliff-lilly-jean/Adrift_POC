using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Move))]
public class Player : MonoBehaviour {

    [Header("Name")]
    [SerializeField] private string _name;

     private GameControls _controls;
     private Rigidbody2D _rb;
     private Move _move;

     private void Awake() {
        _controls = new GameControls();
        _rb = GetComponent<Rigidbody2D>();
        _move = GetComponent<Move>();
    }

    private void OnEnable()
    {
        _controls.Enable();

        // Move
        _controls.Player.Move.performed += _ => _move.getMoveDirection();
        _controls.Player.Move.canceled += _ => _move.resetMoveDirection();
    }

    private void OnDisable()
    {
        _controls.Disable();

        // Move
        _controls.Player.Move.performed -= _ => _move.getMoveDirection();
        _controls.Player.Move.canceled -= _ => _move.resetMoveDirection();
    }

    private void Update() {
        Debug.Log(_move.moveData.direction);
    }

    private void FixedUpdate() {

        // Connect direction to the read value of the controls
        getInputDirection();

        handleMove();

    }

    private void getInputDirection() {
       _move.moveData.direction = _controls.Player.Move.ReadValue<Vector2>();
    }

    private void handleMove() {

        if (_move.moveData.direction == null) return;

        if(_move.moveData.direction != Vector2.zero) {
            _move.accelerate(_rb);
        }else {
            _move.decelerate(_rb);
        }
     }



}