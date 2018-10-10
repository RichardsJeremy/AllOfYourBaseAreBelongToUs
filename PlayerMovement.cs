using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Jeremy Richards S3721762
public class PlayerMovement : MonoBehaviour {

    public float moveSpeed;
    private Vector2 newDirection;
    void Update()
    {
        Vector3 currentPos = gameObject.transform.position;
        int destinationX = 0;
        int destinationY = 0;
        if (Input.GetKey(KeyCode.W))
        {
            destinationY = 1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            destinationX = -1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            destinationY = -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            destinationX = 1;
        }
        float xMove = currentPos.x + destinationX;
        float yMove = currentPos.y + destinationY;
        Vector2 newPos = new Vector2(
            xMove,
            yMove
            );
        gameObject.transform.position = newPos;
    }
}
