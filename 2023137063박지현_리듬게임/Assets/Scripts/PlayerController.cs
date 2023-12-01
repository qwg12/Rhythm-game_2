using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            MovePlayer(0);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            MovePlayer(1);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            MovePlayer(2);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            MovePlayer(3);
        }
    }

    public void MovePlayer(int moveDirection)
    {
        switch (moveDirection)
        {
            case 0: // Up Arrow
                PlayAnimation("Jump");
                break;

            case 1: // Down Arrow
                PlayAnimation("Crouch");
                break;

            case 2: // Left Arrow
                PlayAnimation("MoveLeft");
                break;

            case 3: // Right Arrow
                PlayAnimation("MoveRight");
                break;

            default:
                break;
        }
    }

    void PlayAnimation(string animationName)
    {
        // "animationName"에 해당하는 애니메이션을 재생합니다.
        animator.SetTrigger(animationName);
    }
}
