using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public Transform cameraTransform;
    public float playerSpeed;
    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 cameraDirection = cameraTransform.eulerAngles;
        if (Input.GetKey(KeyCode.UpArrow)) {
            rb.AddForce(playerSpeed * Time.deltaTime * Mathf.Sin(Mathf.Deg2Rad * cameraDirection.y), 0, playerSpeed * Time.deltaTime* Mathf.Cos(Mathf.Deg2Rad * cameraDirection.y));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(-playerSpeed * Time.deltaTime * Mathf.Sin(Mathf.Deg2Rad * cameraDirection.y), 0, -playerSpeed * Time.deltaTime * Mathf.Cos(Mathf.Deg2Rad * cameraDirection.y));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-playerSpeed * Time.deltaTime * Mathf.Cos(Mathf.Deg2Rad * cameraDirection.y), 0, playerSpeed * Time.deltaTime * Mathf.Sin(Mathf.Deg2Rad * cameraDirection.y));
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(playerSpeed * Time.deltaTime * Mathf.Cos(Mathf.Deg2Rad * cameraDirection.y), 0, -playerSpeed * Time.deltaTime * Mathf.Sin(Mathf.Deg2Rad * cameraDirection.y));
        }
    }
}
