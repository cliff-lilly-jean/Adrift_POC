using UnityEngine;
using UnityEngine.Rendering;

[CreateAssetMenu(fileName = "HumanStats", menuName = "Stats/HumanStats")]
public class HumanStats : ScriptableObject {

    int age;
    float stamina;
    int speed;
    int defense;
    int strength;
    float mana;
}