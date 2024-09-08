using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string playerName;

    [Header("Attributes")]
    private Mood mood;
    private Health health;


    // Animations
    private AnimationStateManager animationStateManager;

    void Start()
    {
        // Initialize components
        animationStateManager = GetComponent<AnimationStateManager>();
        animationState = "idle"; // TODO: Convert to an enum or other data structure

        mood = GetComponent<Mood>();
    }
}
