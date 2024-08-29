using UnityEngine;

public abstract class Human : MonoBehaviour {

    public HumanProperties properties;


    // Feeling [State], how you Feel affects your stats
    // ---- Fear, decreases strength
    // ---- Anxious, decreases speed
    // ---- Anger, increases strength
}
