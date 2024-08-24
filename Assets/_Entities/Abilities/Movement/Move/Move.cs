using UnityEngine;

[CreateAssetMenu(menuName = "Ability/Move")]
public class Move : Ability {

    [SerializeField] public float force = 10;
    [SerializeField] public float  acceleration = 2;

}