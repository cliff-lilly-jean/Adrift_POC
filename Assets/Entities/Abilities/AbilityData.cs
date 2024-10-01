using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Data/Ability/Ability Data")]
public class AbilityData : ScriptableObject
{
    public float cooldown;
    public float cost;
    public float strength;

    public Image icon;
    public string description;

}