using UnityEngine;

[CreateAssetMenu(menuName = "Data/Stamina/Stamina Data")]
public class StaminaData : ScriptableObject {

     public float _currentStamina;
     public float _maxStamina;
     public float _recoveryRate;
}