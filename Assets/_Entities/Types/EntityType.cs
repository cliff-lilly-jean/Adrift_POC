using UnityEngine;

[CreateAssetMenu(menuName = "Entity/Type")]
public class EntityType : MonoBehaviour {

    public Type entityType;

   [System.Serializable]
    public enum Type
    {
        Human, // Humans
        Demon, // Demons
        Animal, // Cats, Dogs, etc.
        Insect, // Bugs, Spiders, etc.
        Object, // Things that can't be used: Doors, Chairs
        Item // Things that can be used: Potions, Swords
    }
}