using UnityEngine;

[CreateAssetMenu(menuName = "Data/Stamina/Stamina Data")]
public class StaminaProperties : ScriptableObject {

     public float _currentStamina;
     public float _maxStamina;
     public float _recoveryRate;
}