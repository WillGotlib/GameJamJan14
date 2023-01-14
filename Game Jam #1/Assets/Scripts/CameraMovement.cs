using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 20;
    private Vector3 motion;
    private Vector3 m_EulerAngleVelocity;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        m_EulerAngleVelocity = new Vector3(0, 100, 0);
    }

    // Update is called once per frame
    void Update()
    {
        motion = new Vector3(0, Input.GetAxisRaw("Horizontal"), 0);
        // xThrow = movement.ReadValue<Vector2>().x;
        // yThrow = movement.ReadValue<Vector2>().y;
        m_EulerAngleVelocity = motion * speed;

        Quaternion deltaRotation = Quaternion.Euler(m_EulerAngleVelocity * Time.fixedDeltaTime);
        rb.MoveRotation(rb.rotation * deltaRotation);
    }
}
