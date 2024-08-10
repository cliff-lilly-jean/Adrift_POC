using System;
using System.Collections.Generic;
using UnityEngine;

public static class Abilities {

    // * Definition and reference to all methods and variables pertaining to abilities


    // Get all the abilities and add them to a dictionary
    public static void InitializeAbilities(List<Ability> abilities, Dictionary<Type, Ability> abilityInformation)
    {
        foreach (Ability ability in abilities)
        {
            abilityInformation[ability.GetType()] = ability;
        }
    }



    // Get a specific ability type and add values to it's dictionary entry
    public static T AddAbilityValues<T>(Dictionary<Type, Ability> info) where T : Ability
    {
        info.TryGetValue(typeof(T), out Ability ability);

        return ability as T;
    }


    // Get a specific ability if there is one
    public static T GetAbility<T>(Dictionary<Type, Ability> abilitiesInfo) where T : Ability
    {
        var ability = AddAbilityValues<T>(abilitiesInfo);
        if (ability != null)
        {
            return ability;
            // Use ability properties and methods
        }

        return null;
    }
}