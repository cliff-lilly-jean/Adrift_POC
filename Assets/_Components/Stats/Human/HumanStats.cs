using UnityEngine;


[CreateAssetMenu(menuName = "Stats/HumanStats")]
public class HumanStats : ScriptableObject {

    [Header("Stats")]
    public int age;
    public float stamina;
    public int speed;
    public int defense;
    public int strength;
    public float energy;
}