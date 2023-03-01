using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

// [CreateAssetMenu(fileName = "ScriptableObject")]
public class Player : MonoBehaviour
{
    public int health = 100;
    [SerializeField] private float speed = 15f;

    // holds movement input
    private Vector2 _movementInput;
    // holds smooth movement input
    private Vector2 _smoothedMovementInput;
    // keep track of the veolocity of the change
    private Vector2 _movementInputSmoothVelocity;
    Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        // current
        // rb.velocity = new Vector2(1, 0.5f);
        // revised
        rb.velocity = _smoothedMovementInput;
        _smoothedMovementInput = Vector2.SmoothDamp(_smoothedMovementInput, _movementInput, ref _movementInputSmoothVelocity, 0.1f);
    }

    private void OnMove(InputValue inputValue)
    {
        // Get vector2 value
       _movementInput = inputValue.Get<Vector2>() * speed;

    }
}
