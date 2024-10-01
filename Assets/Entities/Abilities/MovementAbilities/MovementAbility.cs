using UnityEngine;

public class MovementAbility : Ability
{
    public Movement movement;


    private void Start()
    {
        abilityType = AbilityType.MovementAbility;
    }

    private void Update()
    {
        if (abilityType != AbilityType.MovementAbility)
        {
            abilityType = AbilityType.MovementAbility;
        }
    }

    public override void Use()
    {
        throw new System.NotImplementedException();
    }

}