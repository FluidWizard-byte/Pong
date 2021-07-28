using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBall : MonoBehaviour
{
    public int ballspeed = 10;

   public  Rigidbody rb;


    private void Awake()

    {

        rb.velocity = new Vector3(ballspeed, ballspeed, 0);
    }


 
	
}
