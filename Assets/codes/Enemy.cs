using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float speed = 8;
    Vector3 targetPos;
    Vector3 playerPos;
    GameObject ballObj;


	void Start ()
    {
        
	}
	
	
	void Update ()
    {
        ballObj = GameObject.FindGameObjectWithTag("Ball");
        if (ballObj != null)
        {
            targetPos = Vector3.Lerp(gameObject.transform.position, ballObj.transform.position, Time.deltaTime * speed);
            playerPos = new Vector3(-20, Mathf.Clamp(targetPos.y, -9.45f, 9.45f), 0);
            gameObject.transform.position = new Vector3(20, playerPos.y, 0);
        }

	}
}
