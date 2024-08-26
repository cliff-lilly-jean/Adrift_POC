using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class Abilities : MonoBehaviour {

    public List<Ability> abilities = new List<Ability>();

    private void Awake() {
        foreach (var ability in abilities) {
            Debug.Log(ability.description.abilityName);
        }
    }
}