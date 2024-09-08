using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string playerName;

    // Attributes
    private Mood mood;
    private Health health;


    // Animations
    private AnimationState animationState;

    void Start()
    {
        // Initialize components
        animationState = GetComponent<AnimationState>();
        mood = GetComponent<Mood>();
        health = GetComponent<Health>();
    }
}
