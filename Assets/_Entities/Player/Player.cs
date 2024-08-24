using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : Human {

    public Rigidbody2D _rb;

    // Get all the current abilities from the abilities list
    //

    private void Awake() {
         _rb = GetComponent<Rigidbody2D>();
    }


}