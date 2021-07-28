using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Paddle : MonoBehaviour
{
    public float paddleSpeed = 1;
    public Vector3 playerPos;

    void Update()
    {
        float yPos = transform.position.y + (Input.GetAxis("Vertical") * paddleSpeed);
        playerPos = new Vector3(-20, Mathf.Clamp(yPos, -9.45f, 9.45f), 0);
        transform.position = playerPos;
    }
}
