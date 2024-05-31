using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraMovement : MonoBehaviour
{
    public GameObject reference;
    public Vector3 positionOffset;
    public Quaternion rotationOffset;
    private Rigidbody rb;

    private Quaternion rotation;
    private Vector3 test;
    public float rotationMultiplier;
    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
    }

    private void OnCamera(InputValue value)
    {
        //rotation = new Quaternion(value.Get<Vector2>().x, value.Get<Vector2>().y, 0, 0);
    }

    private void FixedUpdate()
    {
        //rb.MoveRotation(rb.rotation * rotation);
        //transform.localRotation *= rotation;
    }
    // Update is called once per frame
    void Update()
    {
      transform.localPosition = reference.transform.localPosition + positionOffset;
      //transform.localRotation = reference.transform.localRotation * rotationOffset;
    }
}
