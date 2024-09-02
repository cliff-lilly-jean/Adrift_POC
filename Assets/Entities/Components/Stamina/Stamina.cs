using UnityEngine;

public class Stamina : MonoBehaviour {

    public StaminaProperties stamina;

    public delegate void staminaChanged(float currentStamina);
    public event staminaChanged OnStaminaChanged;

    public delegate void recover(float recoveryRate);
    public event recover OnRecoverStamina;

    public void Start() {


        stamina._currentStamina = stamina._maxStamina;
    }

    public void decreaseStamina(float staminaDecreaseAmount) {

        stamina._currentStamina -= staminaDecreaseAmount;
        OnStaminaChanged?.Invoke(stamina._currentStamina);

        if (stamina._currentStamina <= 0) {

            OnRecoverStamina?.Invoke(stamina._recoveryRate);
        }
    }

}