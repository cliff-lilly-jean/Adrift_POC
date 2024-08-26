using UnityEngine;

[CreateAssetMenu(menuName = "Data/Human/Human Attributes")]
public class HumanAttributes : ScriptableObject {

    public int age;
    public Birthplace birthplace;
    public Mood mood;

   [System.Serializable]
    public enum Birthplace
    {
        ElderwoodGrove,
        SilverwindHaven,
        ThornbrookHollow,
        StormwatchKeep,
        MoonveilGlade,
        Frostfall,
        CrimsonHollow,
        Brightspire,
        AmberlightOasis,
        VerdantHollow
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