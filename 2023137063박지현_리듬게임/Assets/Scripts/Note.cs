using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    private PlayerController playerController;
    public float speed = 5f; // speed 변수를 정의하고 초기화합니다.
    public int moveDirection; // moveDirection 변수를 정의하고 초기화합니다.

    void Start()
    {
        playerController = FindObjectOfType<PlayerController>();
    }

    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        if (transform.position.y < -5f)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerController.MovePlayer(moveDirection);
            Destroy(gameObject);
        }
    }
}
