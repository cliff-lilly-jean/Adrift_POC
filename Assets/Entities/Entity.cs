using UnityEngine;
using System;

public class Entity : MonoBehaviour {

    private Health _health;


    [SerializeField] EntityType entityType;

    [System.Serializable]
    public enum EntityType {
        Character,
        Item,
        Object,
    }
}