using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBall : PlayerBall
{
    private void FixedUpdate()
    {
        MoveBall();
    }

    public override void MoveBall()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            DrectionX = 1f;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            DrectionX = -1f;
        }
        else
        {
            DrectionX = 0.0f;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            DrectionZ = 1f;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            DrectionZ = -1f;
        }
        else
        {
            DrectionZ = 0.0f;
        }

        MoveDrection.x = DrectionX;
        MoveDrection.z = DrectionZ;
        
        Rb.AddForce(MoveDrection, ForceMode.Force);
    }
}
