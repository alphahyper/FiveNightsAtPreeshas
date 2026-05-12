using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControls : MonoBehaviour
{
    // Start is called before the first frame update
    public Material doorMaterial;
    public Material transparent;
    public MeshRenderer door;
    public static int count = 0;
    public void OnMouseUpAsButton()
    {
        count=(count+1)%2;
        Debug.Log(count);
        if (count == 1)
        {
            door.material = doorMaterial;

            // Allows AI to detect door closure
            if (door.name.Equals("Left Office Doorway Blocker"))
            {
                MovementManager.leftDoorClosed = true;
            }
            else if (door.name.Equals("Right Office Doorway Blocker"))
            {
                MovementManager.rightDoorClosed = true;
            }
            else if (door.name.Equals("Back Office Doorway Blocker"))
            {
                MovementManager.backDoorClosed = true;
            }
        }
        else
        {
            door.material = transparent;
            if (door.name.Equals("Left Office Doorway Blocker"))
            {
                MovementManager.leftDoorClosed = false;
            }
            else if (door.name.Equals("Right Office Doorway Blocker"))
            {
                MovementManager.rightDoorClosed = false;
            }
            else if (door.name.Equals("Back Office Doorway Blocker"))
            {
                MovementManager.backDoorClosed = false;
            }
        }
    }
}
