using UnityEngine;

public class Stamina : MonoBehaviour {

    public delegate void staminaChanged(float currentStamina);
    public event staminaChanged OnStaminaChanged;

    public delegate void recover(float recoveryRate);
    public event recover OnRecoverStamina;

    public void Start() {

        Component.entity.stamina._currentStamina = Component.entity.stamina._maxStamina;
    }

    public void decreaseStamina(float staminaDecreaseAmount) {

        Component.entity.stamina._currentStamina -= staminaDecreaseAmount;
        OnStaminaChanged?.Invoke(Component.entity.stamina._currentStamina);

        if (Component.entity.stamina._currentStamina <= 0) {

            OnRecoverStamina?.Invoke(Component.entity.stamina._recoveryRate);
        }
    }

}