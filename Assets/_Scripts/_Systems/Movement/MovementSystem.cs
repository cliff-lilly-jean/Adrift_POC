using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MovementSystem", menuName = "Systems/MovementSystem")]
public class MovementSystem : ScriptableObject
{
    [Header("Abilities")]
   public List<Ability> movementAbilities = new List<Ability>();

   public Move move;
}
