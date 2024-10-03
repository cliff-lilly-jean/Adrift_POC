using UnityEngine;

[CreateAssetMenu(menuName = "Data/Stats/Movement Stats")]
public class MovementStats : ScriptableObject
{
    public float speed;
    public float maxSpeed;
    public Vector2 direction;
}