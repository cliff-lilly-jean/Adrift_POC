using UnityEngine;

[CreateAssetMenu(menuName = "Data/Human/Human Attributes")]
public class HumanAttributes : ScriptableObject {

    public int age;
    public Birthplace birthplace;
    public Mood mood;

   [System.Serializable]
    public enum Birthplace
    {
        Wrathmoor,
        GreedsLanding,
        PridesReach,
        MoonveilGlade,
        ThornbrookHollow,
        Frostfall,

    }

    [System.Serializable]
    public enum Mood
    {
        Happy,
        Sad,
        Anxious,
        Fearful,
        Angry
    }
}