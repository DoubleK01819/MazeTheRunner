using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField] private Transform _controller;
    private float _xRotetion = 0f;
    public float MouseSensitivity = 100f;


    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * MouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * MouseSensitivity * Time.deltaTime;

        _xRotetion -= mouseY;
        _xRotetion = Mathf.Clamp(_xRotetion, -90f, 90f);

        transform.localRotation = Quaternion.Euler(_xRotetion, 0f, 0f);
        _controller.Rotate(Vector3.up * mouseX);

    }
}
