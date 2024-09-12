using UnityEngine;

public abstract class Character : Entity
{

    // public CharacterStats stats;

    private void Start()
    {

    }


    // Animations
    AnimationState _animationState;

    // See -> Sensory System -> sight at different distances based on factors like; age, weight, height
    // Hear -> Sensory System -> audio at different distances based on factors like; age

    // Walk -> Movement System -> movement based on factors like; direction and speed

    // Fight -> Combat System -> combat based on factors like; attack, defense, stamina, aura

}