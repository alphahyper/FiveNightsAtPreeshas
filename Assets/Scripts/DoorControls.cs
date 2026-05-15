using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControls : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private AudioClip openSound;
    [SerializeField] private AudioClip closeSound;
    private AudioSource soundSource;
    public Material doorMaterial;
    public Material transparent;
    public MeshRenderer door;
    public int count = 0;
    public void OnMouseUpAsButton()
    {
        count=(count+1)%2;
        soundSource = transform.parent.GetComponent<AudioSource>();
        if (count == 1)
        {
            door.material = doorMaterial;
            soundSource.clip = closeSound;
            soundSource.Play();

            // Allows AI to detect door closure
            if (door.name.Equals("Left Mesh"))
            {
                MovementManager.leftDoorClosed = true;
            }
            else if (door.name.Equals("Right Mesh"))
            {
                MovementManager.rightDoorClosed = true;
            }
            else if (door.name.Equals("Back Mesh"))
            {
                MovementManager.backDoorClosed = true;
            }
            Power.ChangeUsage(Power.usage + 1);
        }
        else
        {
            door.material = transparent;

            soundSource.clip = openSound;
            soundSource.Play();

            if (door.name.Equals("Left Mesh"))
            {
                MovementManager.leftDoorClosed = false;
            }
            else if (door.name.Equals("Right Mesh"))
            {
                MovementManager.rightDoorClosed = false;
            }
            else if (door.name.Equals("Back Mesh"))
            {
                MovementManager.backDoorClosed = false;
            }
            Power.ChangeUsage(Power.usage - 1);
        }
    }
}
