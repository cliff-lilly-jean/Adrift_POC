using UnityEngine;

public class Stamina : Component {

    public delegate void staminaChanged(float currentStamina);
    public event staminaChanged OnStaminaChanged;

    public delegate void recover(float recoveryRate);
    public event recover OnRecoverStamina;

    public void Start() {


        entity.stamina._currentStamina = entity.stamina._maxStamina;
    }

    public void decreaseStamina(float staminaDecreaseAmount) {

        entity.stamina._currentStamina -= staminaDecreaseAmount;
        OnStaminaChanged?.Invoke(entity.stamina._currentStamina);

        if (entity.stamina._currentStamina <= 0) {

            OnRecoverStamina?.Invoke(entity.stamina._recoveryRate);
        }
    }

}