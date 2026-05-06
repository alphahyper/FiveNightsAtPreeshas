using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraControls : MonoBehaviour
{
    public static int count = 1;
    public GameObject panel1;
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
    public void ActivateCameras()
    {
        
        panel1.SetActive(false);
        panel2.SetActive(true);
        SwitchCamera();
    }

    public void DeactivateCameras()
    {
        panel1.SetActive(true);
        panel2.SetActive(false);
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
    }

    public void RightCamera()
    {
        count++;
        SwitchCamera();
        count = ((count % 9) + 9) % 9;
    }

    public void LeftCamera()
    {
        count--;
        SwitchCamera();
        count = ((count % 9) + 9) % 9;
    }

    public void SwitchCamera()
    {
        if (count % 9 == 0)
        {
            camera1.enabled = true;
            camera9.enabled = false;
            camera2.enabled = false;
        }
        else if (count % 9 == 1)
        {
            camera2.enabled = true;
            camera1.enabled = false;
            camera3.enabled = false;
        }
        else if (count % 9 == 2)
        {
            camera3.enabled = true;
            camera2.enabled = false;
            camera4.enabled = false;
        }
        else if (count % 9 == 3)
        {
            camera4.enabled = true;
            camera3.enabled = false;
            camera5.enabled = false;
        }
        else if (count % 9 == 4)
        {
            camera5.enabled = true;
            camera4.enabled = false;
            camera6.enabled = false;
        }
        else if (count % 9 == 5)
        {
            camera6.enabled = true;
            camera5.enabled = false;
            camera7.enabled = false;
        }
        else if (count % 9 == 6)
        {
            camera7.enabled = true;
            camera6.enabled = false;
            camera8.enabled = false;
        }
        else if (count % 9 == 7)
        {
            camera8.enabled = true;
            camera7.enabled = false;
            camera9.enabled = false;
        }
        else if (count % 9 == 8)
        {
            camera9.enabled = true;
            camera8.enabled = false;
            camera1.enabled = false;
        }
    }
}
