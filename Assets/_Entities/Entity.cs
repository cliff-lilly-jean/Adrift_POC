using UnityEngine;

public class Entity : MonoBehaviour {

    [SerializeField] private string _entityName;
    [SerializeField] private EntityType _entityType;


    [System.Serializable]
    public enum EntityType
    {
        Character,
        Animal,
        Object,
        Item
    }
}