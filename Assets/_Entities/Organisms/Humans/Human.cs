using UnityEngine;

public abstract class Human : Organism {

    public HumanAttributes attributes;


    // Feeling [State], how you Feel affects your stats
    // ---- Fear, decreases strength
    // ---- Anxious, decreases speed
    // ---- Anger, increases strength
}
