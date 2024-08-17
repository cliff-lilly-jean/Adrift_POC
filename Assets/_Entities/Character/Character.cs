using UnityEngine;

public class Character : Entity {

    [SerializeField] private CharacterStats _characterStats;
    [SerializeField] private CharacterType _characterType;


    [System.Serializable]
    public enum CharacterType {
        Player,
        Enemy,
        NPC,
    }
}