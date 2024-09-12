using UnityEngine;

public class InputController : MonoBehaviour
{

    private Controls _controls;

    private void Start()
    {
        _controls = new Controls();

        _controls.Player.Move.performed += ctx => HandleMove(ctx.ReadValue<Vector2>());
    }

    private void OnEnable()
    {
        _controls.Enable();
    }

    private void OnDisable()
    {
        _controls.Disable();
    }

    private void HandleMove(Vector2 direction)
    {
        // TODO:: Invoke OnMove() event
        Move.OnMovePerformed(direction);
    }
}