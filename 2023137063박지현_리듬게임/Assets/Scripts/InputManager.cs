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
        // ���⿡ ��Ʈ���� �浹 üũ �� �ǵ�� ó���� �߰��� �� �ֽ��ϴ�.
        Debug.Log("Input detected!");
    }
}
