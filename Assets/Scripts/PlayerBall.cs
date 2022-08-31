using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerBall : MonoBehaviour
{
    protected Rigidbody Rb;
    protected Vector3 MoveDrection = Vector3.zero;
    protected float DrectionX = 0.0f;
    protected float DrectionZ = 0.0f;

    void Start()
    {
        Rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.anyKey)
        {
            Rb.useGravity = true;
        }

        if (transform.position.y < -5)
        {
            Destroy(gameObject);
        }
    }

    public abstract void MoveBall();

    private void OnDisable()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameScene");
    }
}
