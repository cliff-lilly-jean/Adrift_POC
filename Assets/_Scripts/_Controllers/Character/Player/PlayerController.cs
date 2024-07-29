using System;
using System.Collections.Generic;
using System.Reflection; // * NOTE: imported to use the PropertyInfo, FieldInfo, GetProperties() and GetFields()
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


    private void Awake() {
        _controls = new GameControls();
        _rb = GetComponentInChildren<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {

        InitializeAbilities();

        // *! Possible implementation??? GetAllAbilities();
    }

     private void OnEnable()
    {
        _controls.Enable();

        _controls.Player.Move.performed += _ => GetMoveAbility().GetMoveDirection();
        _controls.Player.Move.canceled += _ => GetMoveAbility().ResetMoveDirection();

    }

    private void OnDisable()
    {
        _controls.Disable();

        _controls.Player.Move.performed -= _ => GetMoveAbility().GetMoveDirection();
        _controls.Player.Move.canceled -= _ => GetMoveAbility().ResetMoveDirection();

    }

    private void FixedUpdate()
    {
        //
        if (GetMoveAbility()._direction.value == null) return;

        // connect the controls to the direction of the Vector2
        GetMoveAbility()._direction.value = _controls.Player.Move.ReadValue<Vector2>();

        // checking the direction value is not 0
        if(GetMoveAbility()._direction.value != Vector2.zero) {
            GetMoveAbility().Accelerate(_rb);
        }else {
            GetMoveAbility().Decelerate(_rb);
        }
    }

    // Ability Setup
    private void InitializeAbilities()
    {
        foreach (Ability ability in _movementSystem.movementAbilities)
        {
            _abilitiesInfo[ability.GetType()] = ability;
        }
    }


    // Get the ability from the abilities list
    private T GetAbility<T>() where T : Ability
    {
        _abilitiesInfo.TryGetValue(typeof(T), out Ability ability);
        return ability as T;
    }

    // Get Move Ability if there is one in the movement system
    private Move GetMoveAbility()
    {
        var moveAbility = GetAbility<Move>();
        if (moveAbility != null)
        {
            return moveAbility;
            // Use moveAbility properties and methods
        }

        return null;
    }


}
