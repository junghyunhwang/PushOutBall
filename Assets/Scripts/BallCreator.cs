using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCreator : MonoBehaviour
{
    [SerializeField] private GameObject _BBall;
    [SerializeField] private GameObject _RBall;

    void Start()
    {
        /*GameObject ball = GameObject.CreatePrimitive(PrimitiveType.Sphere);

        ball.transform.position = new Vector3(0, 3, 0);

        Rigidbody rb = ball.AddComponent<Rigidbody>();
        rb.mass = 0.2f;

        ball.AddComponent<PlayerBall>();*/

        CreateBall();
    }

    private void CreateBall()
    {
        GameObject ball1 = Instantiate(_RBall);
        GameObject ball2 = Instantiate(_BBall);

        Vector2 spawnPoint = new Vector3(3.5f, 3f);

        ball1.transform.position = spawnPoint;
        ball2.transform.position = spawnPoint * new Vector2(-1f, 1f);
    }
}
