using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string playerName;


    private MentalStateManager mentalStateManager;

    private string animationState;
    private AnimationStateManager animationStateManager;

    void Start()
    {
        // Initialize components
        animationStateManager = GetComponent<AnimationStateManager>();
        animationState = "idle"; // TODO: Convert to an enum or other data structure

        mentalStateManager = GetComponent<MentalStateManager>();
    }
}
