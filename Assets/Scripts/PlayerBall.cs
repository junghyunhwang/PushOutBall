using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerBall : MonoBehaviour
{
    private const float COLLISION_WEIGHT = 7.5f;

    protected Rigidbody Rb;
    protected Vector3 Force;

    void Start()
    {
        Rb = GetComponent<Rigidbody>();
        Force = Vector3.zero;
    }

    void Update()
    {
        if (Input.anyKey)
        {
            Rb.useGravity = true;
        }

        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }
    }

    public abstract void MoveBall();

    private void OnCollisionEnter(Collision collision)
    {
        Force.x = collision.relativeVelocity.x * COLLISION_WEIGHT;
        Force.z = collision.relativeVelocity.z * COLLISION_WEIGHT;

        Rb.AddForce(Force);
    }

    private void OnDisable()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameScene");
    }
}
