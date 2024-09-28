using UnityEngine;

[RequireComponent(typeof(Health))]
[RequireComponent(typeof(Stamina))]
[RequireComponent(typeof(Movement))]
[RequireComponent(typeof(Sprite))]
public class Player : MonoBehaviour
{
    [SerializeField] private string playerName;
    private Health health;
    private Stamina stamina;
    private Movement movement;
    private Sprite sprite;

    private void Start()
    {
        health = GetComponent<Health>();
        stamina = GetComponent<Stamina>();
        movement = GetComponent<Movement>();
        sprite = GetComponent<Sprite>();
    }

}
