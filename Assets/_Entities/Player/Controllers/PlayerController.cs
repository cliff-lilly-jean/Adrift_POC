using System;
using System.Collections.Generic;
using UnityEngine;

// TODO: Add a movementSystem namespace; add all things related to movement

// TODO: Restructure folders by feature, using the namespaces as a base

public class PlayerController : MonoBehaviour
{
    [SerializeField] private MovementSystem _movementSystem;
    [SerializeField] private GameControls _controls;


    private Rigidbody2D _rb;


    // Dictionary to hold the name of the ability string and a Sub Dictionary of each property as key value pairs; string, object
    private Dictionary<Type, Ability> _abilitiesInfo = new Dictionary<Type, Ability>();


    // Animations
    private Animator _animator;
    private string _currentAnimation = "";
    private SpriteRenderer _spriteRenderer;


    private void Awake() {
        _controls = new GameControls();
        _rb = GetComponentInChildren<Rigidbody2D>();
        _animator = GetComponentInChildren<Animator>();
        _spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        // Find all the current abilities attached, then add them to a dictionary
        Abilities.InitializeAbilities(_movementSystem.movementAbilities, _abilitiesInfo);
    }

     private void OnEnable()
    {
        _controls.Enable();

        // Move
        _controls.Player.Move.performed += _ => Abilities.GetAbility<Move>(_abilitiesInfo).getMoveDirection();
        _controls.Player.Move.canceled += _ => Abilities.GetAbility<Move>(_abilitiesInfo).resetMoveDirection();


        // Dash
        _controls.Player.Dash.performed += _ => Abilities.GetAbility<Dash>(_abilitiesInfo).isActive();


        // Attack
        _controls.Player.Attack.performed += _ => Abilities.GetAbility<Attack>(_abilitiesInfo).attack();

    }

    private void OnDisable()
    {
        _controls.Disable();

        // Move
        _controls.Player.Move.performed -= _ => Abilities.GetAbility<Move>(_abilitiesInfo).getMoveDirection();
        _controls.Player.Move.canceled -= _ => Abilities.GetAbility<Move>(_abilitiesInfo).resetMoveDirection();


        // Dash
        _controls.Player.Dash.performed -= _ => Abilities.GetAbility<Dash>(_abilitiesInfo).isActive();

    }


    private void FixedUpdate()
    {

        // Connect direction to the read value of the controls
        GetDirection();

        // Check if any Abilities are being used
        checkMove();
        checkDash();

        // Determine which animation needs to be played
        CheckAnimation();


    }

    private void checkMove() {
        var move = Abilities.GetAbility<Move>(_abilitiesInfo);

        if (move._direction.value == null) return;

        if(move._direction.value != Vector2.zero) {
            move.accelerate(_rb);
        }else {
            move.decelerate(_rb);
        }
    }

    private void checkDash() {
        var dash = Abilities.GetAbility<Dash>(_abilitiesInfo);

        if (dash._isActive.value) {

            dash.executeDash(_rb);

            // start timer to return isDashing value to false
            StartCoroutine(dash.dashCooldownDuration());
        }
    }

    private void checkAttack() {
        var attack = Abilities.GetAbility<Attack>(_abilitiesInfo);

    }

    private void CheckAnimation() {

        var animationCardinalDirection = Animations.CheckAnimationDirection(Abilities.GetAbility<Move>(_abilitiesInfo)._direction.value);

        var newAnimation = Animations.ChangeAnimationDirection(animationCardinalDirection, _spriteRenderer);

        Animations.ChangeAnimation(_currentAnimation, newAnimation, _animator);
    }

    private void GetDirection() {
        Abilities.GetAbility<Move>(_abilitiesInfo)._direction.value = _controls.Player.Move.ReadValue<Vector2>();
    }
}
