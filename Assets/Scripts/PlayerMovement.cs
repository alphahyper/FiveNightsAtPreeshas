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
        if (Input.GetKey(KeyCode.UpArrow)|| Input.GetKey("w")) {
            rb.AddForce(playerSpeed * Time.deltaTime * Mathf.Sin(Mathf.Deg2Rad * cameraDirection.y), 0, playerSpeed * Time.deltaTime* Mathf.Cos(Mathf.Deg2Rad * cameraDirection.y));
        }
        if (Input.GetKey(KeyCode.DownArrow)||Input.GetKey("s"))
        {
            rb.AddForce(-playerSpeed * Time.deltaTime * Mathf.Sin(Mathf.Deg2Rad * cameraDirection.y), 0, -playerSpeed * Time.deltaTime * Mathf.Cos(Mathf.Deg2Rad * cameraDirection.y));
        }
        if (Input.GetKey(KeyCode.LeftArrow)|| Input.GetKey("a"))
        {
            rb.AddForce(-playerSpeed * Time.deltaTime * Mathf.Cos(Mathf.Deg2Rad * cameraDirection.y), 0, playerSpeed * Time.deltaTime * Mathf.Sin(Mathf.Deg2Rad * cameraDirection.y));
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey("d"))
        {
            rb.AddForce(playerSpeed * Time.deltaTime * Mathf.Cos(Mathf.Deg2Rad * cameraDirection.y), 0, -playerSpeed * Time.deltaTime * Mathf.Sin(Mathf.Deg2Rad * cameraDirection.y));
        }
    }
}
