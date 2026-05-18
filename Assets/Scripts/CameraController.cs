using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
   public float mouseSensitivity;
    float camVertRotation = 0f; float camHoriRotation = 0f;
    float inputX; float inputY;
    public static bool cursorLocked = true;

    public Vector3 offset;
    public float rotationSpeed;
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = true;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (cursorLocked)
        {
            transform.position = player.position + offset;
            transform.rotation = player.rotation;
            inputX = Input.GetAxis("Mouse X") * mouseSensitivity;
            inputY = Input.GetAxis("Mouse Y") * mouseSensitivity;

            camVertRotation -= inputY;
            camHoriRotation -= inputX;
            camVertRotation = Mathf.Clamp(camVertRotation, -90f, 90f);
            transform.eulerAngles = new Vector3(camVertRotation, -1 * camHoriRotation);
        }
        
        transform.position = player.position + offset;

        /*if (Input.GetMouseButton(0))
        { // If left mouse button is held down
            float h = rotationSpeed * Input.GetAxis("Mouse X");
            float v = rotationSpeed * Input.GetAxis("Mouse Y");

            // Rotate the pivot
            transform.Rotate(v, -h, 0); // Need to adjust for axis preference
            Vector3 currentEuler = transform.eulerAngles;
            transform.eulerAngles = new Vector3(currentEuler.x, currentEuler.y, 0);
        }*/
        

    }

}
