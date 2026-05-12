using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementManager : MonoBehaviour
{
    public static bool leftDoorClosed;
    public static bool rightDoorClosed;
    public static bool backDoorClosed;
    public static Transform[] rooms;
    public static Dictionary<int, string> roomPairs;  // A dictionary of all rooms and their indexes (indices can be changed each mvt script)
    // Start is called before the first frame update
    void Start()
    {
        leftDoorClosed = false; rightDoorClosed = false; backDoorClosed = false;

        rooms = GameObject.Find("Teleportation Points").GetComponentsInChildren<Transform>();
        roomPairs = new Dictionary<int, string>();
        roomPairs.Add(-1, "Office");
        roomPairs.Add(0, "TPServer");
        roomPairs.Add(1, "TPScience");
        roomPairs.Add(2, "TPScience2");
        roomPairs.Add(3, "TPDECA");
        roomPairs.Add(4, "TPCafeteria"); 
        roomPairs.Add(5, "TPH1");
        roomPairs.Add(6, "TPH2");
        roomPairs.Add(7, "TPH3");
        roomPairs.Add(8, "TPH4");
        roomPairs.Add(9, "TPH5");
        roomPairs.Add(10, "TPH6");
        roomPairs.Add(11, "TPH7");
        roomPairs.Add(12, "TPEnglish");
        roomPairs.Add(13, "TPMath");
        roomPairs.Add(14, "TPEntrance");
        roomPairs.Add(15, "TPLounge");
    }
}
