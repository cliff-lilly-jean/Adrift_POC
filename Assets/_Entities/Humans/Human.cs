using UnityEngine;

public abstract class Human : Entity {

    private Move _move;

    private void Start() {
        _move = GetComponentInChildren<Move>();
    }

    // Feeling [State], how you Feel affects your stats
    // ---- Fear, decreases strength
    // ---- Anxious, decreases speed
    // ---- Anger, increases strength
}