using UnityEngine;
using System;

public class Entity : MonoBehaviour {


    [SerializeField] EntityType entityType;

    [System.Serializable]
    public enum EntityType {
        Character,
        Item,
        Object,
    }
}