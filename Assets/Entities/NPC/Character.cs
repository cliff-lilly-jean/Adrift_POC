using UnityEngine;
using System.Collections.Generic;

public abstract class Character: Entity {

    public static MoveProperties moveProperties;
    public static List<AbilityProperties> abilities = new List<AbilityProperties>();
}