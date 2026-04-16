using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using Random = UnityEngine.Random;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private int room;
    private float timeLeft;
    private float minTime, maxTime;
    // Start is called before the first frame update
    void Start()
    {
        room = 0;
        minTime = 2f; maxTime = 10f;  // CHANGES TIMER
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
    // CHANGE WHEN MODELS ARE MADE
    void MoveRoom(ref int room)
    {
        Debug.Log($"Moved to room {room + 1}");
        room++;
    }
}
