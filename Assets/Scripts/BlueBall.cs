using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBall : PlayerBall
{
    public BlueBall()
    {
        Debug.Log("Create Blue Ball");
    }

    private void FixedUpdate()
    {
        MoveBall();
    }

    public override void MoveBall()
    {
        if (Input.GetKey(KeyCode.D))
        {
            DrectionX = 1f;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            DrectionX = -1f;
        }
        else
        {
            DrectionX = 0.0f;
        }

        if (Input.GetKey(KeyCode.W))
        {
            DrectionZ = 1f;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            DrectionZ = -1f;
        }
        else
        {
            DrectionZ = 0.0f;
        }

        MoveDrection = new Vector3(DrectionX, 0.0f, DrectionZ);

        Rb.AddForce(MoveDrection, ForceMode.Force);
    }
}
