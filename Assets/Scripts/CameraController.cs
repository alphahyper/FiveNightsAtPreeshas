using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public float rotationSpeed;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = player.position + offset;

        if (Input.GetMouseButton(0))
        { // If left mouse button is held down
            float h = rotationSpeed * Input.GetAxis("Mouse X");
            float v = rotationSpeed * Input.GetAxis("Mouse Y");

            // Rotate the pivot
            transform.Rotate(v, -h, 0); // Need to adjust for axis preference
            Vector3 currentEuler = transform.eulerAngles;
            transform.eulerAngles = new Vector3(currentEuler.x, currentEuler.y, 0);
        }
    }


}
