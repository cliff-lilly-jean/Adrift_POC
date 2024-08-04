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
    private Directions _directions;
    private float tolerance = 0.01f;
    private bool _isEast;


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
        Debug.Log(GetMoveAbility()._direction.value);
        Debug.Log(CheckAnimation());
    }

    private void FixedUpdate()
    {

        CheckAnimation();


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

    private Directions CheckAnimation() {

        Directions currentDirection = GetCurrentDirection();
        Debug.Log($"Current direction: {currentDirection}");

         switch (currentDirection)
        {
            case Directions.NorthEast:
                _spriteRenderer.flipX = false;
                ChangeAnimation("Walk_R");
                _directions = Directions.NorthEast;
                _isEast = true;
                break;
            case Directions.NorthWest:
                _spriteRenderer.flipX = true;
                ChangeAnimation("Walk_R");
                _directions = Directions.NorthWest;
                _isEast = false;
                break;
            case Directions.SouthEast:
                _spriteRenderer.flipX = false;
                ChangeAnimation("Walk_R");
                _directions = Directions.SouthEast;
                _isEast = true;

                break;
            case Directions.SouthWest:
                _spriteRenderer.flipX = true;
                ChangeAnimation("Walk_R");
                _directions = Directions.SouthWest;
                _isEast = false;

                break;
            case Directions.North:
                ChangeAnimation("Walk_B");
                _directions = Directions.North;
                _isEast = false;

                break;
            case Directions.South:
                ChangeAnimation("Walk_F");
                _directions = Directions.South;

                break;
            case Directions.East:
                _spriteRenderer.flipX = false;
                ChangeAnimation("Walk_R");
                _directions = Directions.East;
                _isEast = true;

                break;
            case Directions.West:
                _spriteRenderer.flipX = true;
                ChangeAnimation("Walk_R");
                _directions = Directions.West;
                _isEast = false;

                break;
            default:
                break;
        }

        return _directions;
    }


    private Directions GetCurrentDirection()
    {
        Vector2 direction = GetMoveAbility()._direction.value;

        // Check the direction values with an amount of tolerance + or - to account for vector floats not being precise
        if (IsApproximatelyEqual(direction, new Vector2(0.71f, 0.71f), tolerance))
            return Directions.NorthEast;
        if (IsApproximatelyEqual(direction, new Vector2(-0.71f, 0.71f), tolerance))
            return Directions.NorthWest;
        if (IsApproximatelyEqual(direction, new Vector2(0.71f, -0.71f), tolerance))
            return Directions.SouthEast;
        if (IsApproximatelyEqual(direction, new Vector2(-0.71f, -0.71f), tolerance))
            return Directions.SouthWest;
        if (IsApproximatelyEqual(direction, new Vector2(0, 1), tolerance))
            return Directions.North;
        if (IsApproximatelyEqual(direction, new Vector2(0, -1), tolerance))
            return Directions.South;
        if (IsApproximatelyEqual(direction, new Vector2(1, 0), tolerance))
            return Directions.East;
        if (IsApproximatelyEqual(direction, new Vector2(-1, 0), tolerance))
            return Directions.West;


        return Directions.None;
    }

    private bool IsApproximatelyEqual(Vector2 a, Vector2 b, float tolerance)
    {
        // Get the absolute value of the x's and ys and determine if they're less than the tolerance level
        return Mathf.Abs(a.x - b.x) < tolerance && Mathf.Abs(a.y - b.y) < tolerance;
    }



    public enum Directions {
        North,
        South,
        East,
        West,
        NorthWest,
        SouthWest,
        NorthEast,
        SouthEast,
        None
    }
}
