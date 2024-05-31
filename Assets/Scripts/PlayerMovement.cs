using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public Camera Camera1;
    public Camera Camera2;
    private Vector3 movement;
    //private float aPressed;
    private Rigidbody rb;
    public float speedMultiplier;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnMovement(InputValue value)
    {
        movement = new Vector3(-value.Get<Vector2>().y, 0, value.Get<Vector2>().x);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * Time.fixedDeltaTime * speedMultiplier);
    }
}