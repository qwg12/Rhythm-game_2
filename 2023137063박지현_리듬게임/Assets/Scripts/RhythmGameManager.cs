using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RhythmGameManager : MonoBehaviour
{
    public GameObject notePrefab;
    public Transform[] spawnPoints;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            SpawnNote(0); // Up Arrow
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            SpawnNote(1); // Down Arrow
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            SpawnNote(2); // Left Arrow
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            SpawnNote(3); // Right Arrow
        }
    }

    void SpawnNote(int spawnIndex)
    {
        Instantiate(notePrefab, spawnPoints[spawnIndex].position, Quaternion.identity);
    }
}
