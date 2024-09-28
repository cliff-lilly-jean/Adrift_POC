using UnityEngine;

[CreateAssetMenu(menuName = "Data/Movement/Movement Data")]
public class MovementData : ScriptableObject
{
    public float speed;
    public float maxSpeed;
    public Vector2 direction;

}