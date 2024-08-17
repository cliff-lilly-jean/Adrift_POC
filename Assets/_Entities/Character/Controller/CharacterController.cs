using UnityEngine;

public abstract class CharacterController : MonoBehaviour
{
    [SerializeField] private Character character;

    private void OnEnable()
    {
        // Subscribe to the events
        character.OnMove += HandleMove;
        character.OnDash += HandleDash;
        character.OnInteract += HandleInteract;
        character.OnAttack += HandleAttack;
    }

    private void OnDisable()
    {
        // Unsubscribe from the events
        character.OnMove -= HandleMove;
        character.OnDash -= HandleDash;
        character.OnInteract -= HandleInteract;
        character.OnAttack -= HandleAttack;
    }

    public abstract void HandleMove(Vector2 direction);
    public abstract void HandleDash(Vector2 direction);
    public abstract void HandleInteract(GameObject character);
    public abstract void HandleAttack(GameObject character);

}
