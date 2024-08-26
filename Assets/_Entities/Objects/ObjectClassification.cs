using UnityEngine;

[CreateAssetMenu(menuName = "Data/Object/Object Classification")]
public class ObjectClassification : ScriptableObject {

    public Type objectType;

   [System.Serializable]
    public enum Type
    {
       Item,
       Weapon,
       Armor,
       Tool,
       Object,
       Currency,
    }
}