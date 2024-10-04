using UnityEngine;

public class Dash : Ability
{
    public Movement movement;

    private void Start()
    {
        type = AbilityType.Dash;
    }

    private void Update()
    {
        // Debug.Log(type);
        // Debug.Log(GetAbilityDescription(type));
    }

    public override void Use()
    {
        //    TODO: Implement

        // AbilityType abilityType;

        // switch (abilityType)
        // {
        //     case AbilityType.Dash:
        //         Debug.Log("Provides a movement boost in a direction.");
        //     case AbilityType.Healing:
        //         return "Restores a portion of health to the target.";
        //         Debug.Log("Provides a movement boost in a direction.");
        //     case AbilityType.Stealth:
        //         return "Temporarily makes the character invisible to enemies.";
        //         Debug.Log("Provides a movement boost in a direction.");
        //     case AbilityType.Shield:
        //         return "Creates a protective barrier that absorbs damage.";
        //     case AbilityType.Ki:
        //         return "Creates a ki blast.";
        //     default:
        //         return "Unknown ability.";
        // }
    }
}