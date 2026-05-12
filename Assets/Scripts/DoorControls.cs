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
        }
        else
        {
            door.material = transparent;
        }
    }
}
