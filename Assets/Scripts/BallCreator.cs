using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCreator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject ball = GameObject.CreatePrimitive(PrimitiveType.Sphere);

        ball.transform.position = new Vector3(0, 3, 0);

        Rigidbody rb = ball.AddComponent<Rigidbody>();
        rb.mass = 0.2f;

        ball.AddComponent<PlayerBall>();
    }
}
