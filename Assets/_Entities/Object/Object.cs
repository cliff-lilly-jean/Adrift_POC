using UnityEngine;

public class Object : MonoBehaviour {

    public ObjectType type;

    [System.Serializable]
    public enum ObjectType
    {
        Item,
        Weapon,
        Armor,
        Tool,
        Object,
        Currency,
    }
}