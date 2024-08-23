using UnityEngine;

public abstract class CharacterController2D : MonoBehaviour
{
    [Header("Mechanics")]
    public Move move;
    // // [SerializeField] public Interact _interact;
    // // [SerializeField] public Attack _attack;
    public Dash dash;


    private void Awake() {
        move = new Move();
    }
}
