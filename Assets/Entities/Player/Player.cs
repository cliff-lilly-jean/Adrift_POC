using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] string _playerName;




    // Attributes
    Mood _mood;
    Health _health;

    // Abilities
    Abilities _abilities;


    // Animations
    AnimationState _animationState;

    void Start()
    {
        // Initialize components
        _animationState = GetComponent<AnimationState>();
        _mood = GetComponent<Mood>();
        _health = GetComponent<Health>();
        _abilities = GetComponent<Abilities>();
    }
}
