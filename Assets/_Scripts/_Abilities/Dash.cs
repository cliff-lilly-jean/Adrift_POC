using System.Collections;
using UnityEngine;

[CreateAssetMenu(fileName = "Dash", menuName = "Abilities/Dash")]
public class Dash : Ability {

    [Header("Dash Attributes")]
    public BoolVariable _isActive;

    [Header("Boost")]
    public FloatVariable _dashSpeedBoost;

    [Header("Dash Duration")]
    public FloatVariable _duration;

    [Header("Dash Duration")]
    public Vector2Variable _direction;

    [Header("Velocity")]
    public FloatVariable _acceleration;
    public FloatVariable _forceMultiplier;


    // Methods

     public void ExecuteDash(Rigidbody2D rb) {

         // move the position of the rigidbody multiplied by the movement speed and the dash speed;
        rb.AddForce(_direction.value * _acceleration.value * _dashSpeedBoost.value * _forceMultiplier.value, ForceMode2D.Force);

        // TODO: add trail when dashing
    }


    public void IsActive() {
        _isActive.value = true;
    }

    // turn isDashing to false after a certain period of time
    public IEnumerator DashDuration() {
        yield return new WaitForSeconds(_duration.value);
        _isActive.value = false;
    }

}