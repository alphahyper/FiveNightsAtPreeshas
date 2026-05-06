using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using Random = UnityEngine.Random;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private int[] roomIndices;
    private int room;
    private Vector3 roomPos;
    private float timeLeft;
    private float minTime, maxTime;
    // Start is called before the first frame update
    void Start()
    {
        roomIndices = new int[] {14,4,12,13,9,8,1,2};
        room = 0;
        MoveRoom(ref room);
        minTime = 2f; maxTime = 3f;  // CHANGES TIMER
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
}
