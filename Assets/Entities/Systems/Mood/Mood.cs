using UnityEngine;

public class Mood : MonoBehaviour {

    private Moods currentMood;

    private enum Moods {
        Normal,
        Happy,
        Sad,
        Angry,
        Anxious,
        Scared
    }

    private void Start() {
        currentMood = Moods.Normal;
    }

    public void ChangeMood(Moods newMood)
    {
        if (currentMood != newMood)
        {
            currentMood = newMood;
        }
    }

}