using UnityEngine;

public abstract class Ability : ScriptableObject {

    public StringVariable Name;
    public StringVariable description;
    public FloatVariable cost;
    public FloatVariable cooldown;

    [System.Serializable]
    public enum Type {
        Movement,
        Melee,
        Ki
    }

    [SerializeField] public Type type;

    public abstract void Use();
}