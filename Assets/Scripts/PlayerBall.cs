using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class PlayerBall : MonoBehaviour
{
    private Text RestartTxT;

    protected Rigidbody Rb;
    protected Vector3 MoveDrection;
    protected float DrectionX = 0.0f;
    protected float DrectionZ = 0.0f;

    private void Awake()
    {
        RestartTxT = GameObject.Find("RestartTxT").GetComponent<Text>();
    }

    void Start()
    {
        RestartTxT.gameObject.SetActive(false);

        Rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (transform.position.y < -5)
        {
            Destroy(gameObject);
        }
    }

    private void OnDisable()
    {
        RestartTxT.gameObject.SetActive(true);
    }

    public abstract void MoveBall();
}
