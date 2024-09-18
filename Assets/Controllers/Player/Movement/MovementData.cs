using UnityEngine;

[CreateAssetMenu(menuName = "Data/Controllers/Movement/Movement Data")]
public class MovementData : ScriptableObject
{
    public float speed;
    public float speedMax;
    public Vector2 direction;

    private void Start()
    {
        speed = speedMax;
    }


}