using System;
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Obstacle"))
        {
            movement.enabled = false;
            FindAnyObjectByType<GameManage>().EndGame();
        }
    }
}
