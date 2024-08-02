using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

// TODO: Add a movementSystem namespace; add all things related to movement

// TODO: Restructure folders by feature, using the namespaces as a base

public class PlayerController : MonoBehaviour
{
    [SerializeField] private MovementSystem _movementSystem;
    [SerializeField] private GameControls _controls;
    private Rigidbody2D _rb;

    // Dictionary to hold the name of the ability; string and a Dictionary of each property as key value pairs; string, object
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
        InitializeAbilities(_movementSystem.movementAbilities, _abilitiesInfo);

        // *! Possible implementation GetAllAbilities()???, meaning ex. Movement, Melee etc.
    }

     private void OnEnable()
    {
        _controls.Enable();

        // Move
        _controls.Player.Move.performed += _ => GetMoveAbility().GetMoveDirection();
        _controls.Player.Move.canceled += _ => GetMoveAbility().ResetMoveDirection();


        // Dash
        _controls.Player.Dash.performed += _ => GetDashAbility().IsActive();

    }

    private void OnDisable()
    {
        _controls.Disable();

        // Move
        _controls.Player.Move.performed -= _ => GetMoveAbility().GetMoveDirection();
        _controls.Player.Move.canceled -= _ => GetMoveAbility().ResetMoveDirection();


        // Dash
        _controls.Player.Dash.performed -= _ => GetDashAbility().IsActive();

    }

    private void Update() {
        CheckAnimation();

        Debug.Log(GetMoveAbility()._direction.value);
    }

    private void FixedUpdate()
    {
        // Move
        if (GetMoveAbility()._direction.value == null) return;

        // connect direction to the read value of the controls
        GetMoveAbility()._direction.value = _controls.Player.Move.ReadValue<Vector2>();

        // checking the direction value is not 0, and if not move
        if(GetMoveAbility()._direction.value != Vector2.zero) {
            GetMoveAbility().Accelerate(_rb);
        }else {
            GetMoveAbility().Decelerate(_rb);
        }



        // Dash
        if (GetDashAbility()._isActive.value) {
            GetDashAbility().ExecuteDash(_rb);

            // start timer to return isDashing value to false
            StartCoroutine(GetDashAbility().DashDuration());
        }

    }

    // Ability Setup
    private void InitializeAbilities(List<Ability> abilities, Dictionary<Type, Ability> abilityInformation)
    {
        foreach (Ability ability in abilities)
        {
            abilityInformation[ability.GetType()] = ability;
        }
    }


    // Get the ability from the abilities list
    private T GetAbility<T>(Dictionary<Type, Ability> info) where T : Ability
    {
        info.TryGetValue(typeof(T), out Ability ability);
        return ability as T;
    }

    // Get Move Ability if there is one in the movement system
    private Move GetMoveAbility()
    {
        var moveAbility = GetAbility<Move>(_abilitiesInfo);
        if (moveAbility != null)
        {
            return moveAbility;
            // Use moveAbility properties and methods
        }

        return null;
    }

    // Get Move Ability if there is one in the movement system
    private Dash GetDashAbility()
    {
        var dashAbility = GetAbility<Dash>(_abilitiesInfo);
        if (dashAbility != null)
        {
            return dashAbility;

            // Use moveAbility properties and methods
        }

        return null;
    }


    // Animations
    private void ChangeAnimation(string animation, float crossFade = 0.2f) {

        if (_currentAnimation != animation) {
            _currentAnimation = animation;
            _animator.CrossFade(animation, crossFade);
        }
    }

    private void CheckAnimation() {

        if(GetMoveAbility()._direction.value.y == 1) {
            ChangeAnimation("Walk_B");
        } else if (GetMoveAbility()._direction.value.y == -1) {
            ChangeAnimation("Walk_F");
        } else if (GetMoveAbility()._direction.value.x == 1) {
            _spriteRenderer.flipX = false;
            ChangeAnimation("Walk_R");
        } else if (GetMoveAbility()._direction.value.x == -1) {
            _spriteRenderer.flipX = true;
            ChangeAnimation("Walk_R");
        } else {
            // Check the last pressed direction
            // --- store the 4 cardinal directions, N, S, E, W
            // --- store a cardinal direction in a variable, currentFacingDirection returned by each of the direction values of the CheckAnimation method
            // ---- determine the correct idle animation based off of the stored cardinal direction
            // * Note: May need to be run in an update loop, since the cardinal direction variable will have to be updated on every keypress


            // Change the Idle animation to that direction
            ChangeAnimation("Idle_F");
        }
    }


}
