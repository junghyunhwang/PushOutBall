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
            Force.x = 1f;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            Force.x = -1f;
        }
        else
        {
            Force.x = 0.0f;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            Force.z = 1f;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            Force.z = -1f;
        }
        else
        {
            Force.z = 0.0f;
        }
        
        Rb.AddForce(Force, ForceMode.Force);
    }
}
