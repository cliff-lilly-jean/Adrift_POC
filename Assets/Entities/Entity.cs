using System;
using UnityEngine;
using UnityEngine.TextCore.Text;

public abstract class Entity : MonoBehaviour {

    public Classification classification;

    [System.Serializable]
    public enum Classification {
        Character,
        Item,
        Object,
    }

    private void Update() {

    }


}