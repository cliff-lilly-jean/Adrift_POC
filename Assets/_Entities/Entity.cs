using UnityEngine;

public abstract class Entity : MonoBehaviour {

    [SerializeField] private string _name;
    [SerializeField] private Type _type;
    [SerializeField] private Health _health;


    [System.Serializable]
    public enum Type
    {
        Human, // Humans
        Demon, //
        Animal, // Cats, Dogs, etc.
        Insect, // Bugs, Spiders, etc.
        Object, // Things that can't be used: Doors, Chairs
        Item // Things that can be used: Potions, Swords
    }
}