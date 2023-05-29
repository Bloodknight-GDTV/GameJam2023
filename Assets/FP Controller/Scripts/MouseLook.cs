using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    public float mouseSensitivity = 1500f;

    Transform player;
    float xRot;

    void Start()
    {
        player = transform.parent;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float modifier = 1.0f;
        
        #if UNITY_WEBGL
            modifier = 0.05f;
        #else
            modifier = 1f;    
        #endif
        
#if UNITY_EDITOR
        modifier = 1f;
#endif
        
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * modifier * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * modifier * Time.deltaTime;
        
        xRot -= mouseY;
        xRot = Mathf.Clamp(xRot, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRot, 0, 0);

        player.Rotate(Vector3.up * mouseX);

    }

}
