using UnityEngine;

[CreateAssetMenu(menuName = "Data/Organism/Organism Info")]
public class OrganismInfo : ScriptableObject {

    public string _name = "New name here";
    public Type organismType;

   [System.Serializable]
    public enum Type
    {
        Human,
        Demon,
        Animal,
        Insect,
        Celestial
    }

}