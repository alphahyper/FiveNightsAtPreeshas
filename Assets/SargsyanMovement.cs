using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class SargsyanMovement : MonoBehaviour
{
    public static bool isScaring;
    public GameObject sargsyanFace;
    private int[] roomIndices;
    private int room;
    private Vector3 roomPos;
    private float timeLeft;
    private float minTime, maxTime;
    // Start is called before the first frame update
    void Start()
    {
        isScaring = false;
        roomIndices = new int[] { 15,10,4,3,7,0,5,-1};
        room = 0;
        MoveRoom(ref room);
        minTime = 1f; maxTime = 2f;  // CHANGES TIMER
        timeLeft = Random.Range(minTime, maxTime);
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            MoveRoom(ref room);
            timeLeft = Random.Range(minTime, maxTime);
            if (room % roomIndices.Length == 0)  // If AI reaches the office
            {
                if (MovementManager.rightDoorClosed == false)
                {
                    if (!Movement.isScaring)
                    {
                        Jumpscare();
                    }
                }
            }
        }
    }

    // Moves the AI to the next room
    void MoveRoom(ref int room)
    {
        String roomName = MovementManager.roomPairs[roomIndices[room++ % roomIndices.Length]];
        foreach (Transform rm in MovementManager.rooms)
        {
            if (rm.name == roomName)
            {
                transform.position = rm.position;
                break;
            }
        }
    }
    async void Jumpscare()
    {
        isScaring = true;
        HUDManager.HideOfficeHUD();
        sargsyanFace.SetActive(true);
        await Task.Delay(3000);
        SceneManager.LoadScene("Game Over Screen");
    }
}
