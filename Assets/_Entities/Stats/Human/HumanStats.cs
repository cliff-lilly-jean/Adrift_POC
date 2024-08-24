using UnityEngine;


[CreateAssetMenu(menuName = "Stats/HumanStats")]
public class HumanStats : Stats {

    [Header("Stats")]
    public int age;
    public float stamina;
    public int speed;
    public int strength;
    public float energy;
}