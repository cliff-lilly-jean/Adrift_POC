using UnityEngine;

public class Stamina : MonoBehaviour {

    public StaminaData data;

    public delegate void staminaChanged(float currentStamina);
    public event staminaChanged OnStaminaChanged;

    public delegate void recover(float recoveryRate);
    public event recover OnRecoverStamina;

    public void Start() {
        data._currentStamina = data._maxStamina;
    }

    public void decreaseStamina(float staminaDecreaseAmount) {

        data._currentStamina -= staminaDecreaseAmount;
        OnStaminaChanged?.Invoke(data._currentStamina);

        if (data._currentStamina <= 0) {

            OnRecoverStamina?.Invoke(data._recoveryRate);
        }
    }

}