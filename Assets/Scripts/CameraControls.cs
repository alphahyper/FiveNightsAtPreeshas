using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public class CameraControls : MonoBehaviour
{
    public static int count = 0;
    public static int qCount = 0;
    public GameObject clockText;
    public GameObject camIcon;
    public GameObject panel2;
    public Camera mainCamera;
    public Camera camera1;
    public Camera camera2;
    public Camera camera3;
    public Camera camera4;
    public Camera camera5;
    public Camera camera6;
    public Camera camera7;
    public Camera camera8;
    public Camera camera9;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (count % 2 == 0)
            {
                ActivateCameras();
            }
            else
            {
                DeactivateCameras();
            }
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (count % 2 == 0)
            {
                UnityEngine.Cursor.lockState = CursorLockMode.None;
                UnityEngine.Cursor.visible = true;
                count++;
            }
            else
            {
                UnityEngine.Cursor.lockState = CursorLockMode.Locked;
                count++;
            }
            
        }
    }
    public void ActivateCameras()
    {
        count++;
        UnityEngine.Cursor.lockState = CursorLockMode.None;
        UnityEngine.Cursor.visible = true;
        CameraController.cursorLocked = false;
        
        clockText.SetActive(false);
        camIcon.SetActive(false);
        panel2.SetActive(true);
        Power.ChangeUsage(Power.usage + 1);
        SwitchCamera("Entrance Camera");
    }

    public void DeactivateCameras()
    {
        count++;
        UnityEngine.Cursor.lockState = CursorLockMode.Locked;
        CameraController.cursorLocked = true;
        clockText.SetActive(true);
        camIcon.SetActive(true);
        panel2.SetActive(false);
        //CameraController.cursorLocked = true;
        camera1.enabled = false;
        camera2.enabled = false;
        camera3.enabled = false;
        camera4.enabled = false;
        camera5.enabled = false;
        camera6.enabled = false;
        camera7.enabled = false;
        camera8.enabled = false;
        camera9.enabled = false;
        mainCamera.enabled = true;
        Power.ChangeUsage(Power.usage - 1);
        FaceCamera.ChangeCurrentCamera(Camera.main.transform);
    }

    /*public void RightCamera()
    {
        count++;
        SwitchCamera("a");
        count = ((count % 9) + 9) % 9;
    }

    public void LeftCamera()
    {
        count--;
        SwitchCamera("a");
        count = ((count % 9) + 9) % 9;
    }*/

    public void SwitchCamera(string cam)
    {
        camera1.enabled = false;
        camera2.enabled = false;
        camera3.enabled = false;
        camera4.enabled = false;
        camera5.enabled = false;
        camera6.enabled = false;
        camera7.enabled = false;
        camera8.enabled = false;
        camera9.enabled = false;
        if (cam.Equals("Office Camera"))
        {
            camera1.enabled = true;
            FaceCamera.ChangeCurrentCamera(camera1.transform);
        }
        else if (cam.Equals("Science Camera"))
        {
            camera2.enabled = true;
            FaceCamera.ChangeCurrentCamera(camera2.transform);
        }
        else if (cam.Equals("Server Camera"))
        {
            camera3.enabled = true;
            FaceCamera.ChangeCurrentCamera(camera3.transform);
        }
        else if (cam.Equals("DECAMart Camera"))
        {
            camera4.enabled = true;
            FaceCamera.ChangeCurrentCamera(camera4.transform);
        }
        else if (cam.Equals("Teacher Lounge Camera"))
        {
            camera5.enabled = true;
            FaceCamera.ChangeCurrentCamera(camera5.transform);
        }
        else if (cam.Equals("Entrance Camera"))
        {
            camera6.enabled = true;
            FaceCamera.ChangeCurrentCamera(camera6.transform);
        }
        else if (cam.Equals("Math Camera"))
        {
            camera7.enabled = true;
            FaceCamera.ChangeCurrentCamera(camera7.transform);
        }
        else if (cam.Equals("English Camera"))
        {   
            camera8.enabled = true;
            FaceCamera.ChangeCurrentCamera(camera8.transform);
        }
        else if (cam.Equals("Cafeteria Camera"))
        {
            camera9.enabled = true;
            FaceCamera.ChangeCurrentCamera(camera9.transform);
        }
        
    }
}
