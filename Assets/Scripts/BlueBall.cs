using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBall : PlayerBall
{
    private void FixedUpdate()
    {
        MoveBall();
    }

    public override void MoveBall()
    {
        if (Input.GetKey(KeyCode.D))
        {
            Force.x = 1f;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            Force.x = -1f;
        }
        else
        {
            Force.x = 0.0f;
        }

        if (Input.GetKey(KeyCode.W))
        {
            Force.z = 1f;
        }
        else if (Input.GetKey(KeyCode.S))
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
