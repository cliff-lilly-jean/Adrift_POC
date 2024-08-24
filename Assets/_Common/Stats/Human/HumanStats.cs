using UnityEngine;


[CreateAssetMenu(fileName = "HumanStats", menuName = "Stats/HumanStats")]
public class HumanStats : ScriptableObject {

    [Header("Stats")]
    int age;
    float stamina;
    int speed;
    int defense;
    int strength;
    float energy;
}