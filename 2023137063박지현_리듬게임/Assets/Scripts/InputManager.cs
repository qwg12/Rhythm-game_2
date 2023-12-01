using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public KeyCode inputKey = KeyCode.Space;

    void Update()
    {
        if (Input.GetKeyDown(inputKey))
        {
            CheckNoteInput();
        }
    }

    void CheckNoteInput()
    {
        // 여기에 노트와의 충돌 체크 및 피드백 처리를 추가할 수 있습니다.
        Debug.Log("Input detected!");
    }
}
