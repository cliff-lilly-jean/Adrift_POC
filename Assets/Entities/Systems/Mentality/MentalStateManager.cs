using UnityEngine;

public class MentalStateManager : MonoBehaviour {

    private MentalState mentalState;

    void Start()
    {
        mentalState = GetComponent<MentalState>();
    }

    // public void SetAnimation(string animationName)
    // {
    //     animator.Play(animationName);
    // }
}