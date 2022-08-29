using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBall : MonoBehaviour
{
    enum EBallColor
    {
        Blue,
        Red
    }

    [SerializeField] private Text RestartTxT;
    private Rigidbody Rb;
    private Vector3 MoveDrection;
    [SerializeField] EBallColor PlayerColor;
    private float DrectionX = 0.0f;
    private float DrectionZ = 0.0f;

    private void Awake()
    {
        Rb = GetComponent<Rigidbody>();

        RestartTxT = GameObject.Find("RestartTxT").GetComponent<Text>();
    }

    void Start()
    {
        RestartTxT.gameObject.SetActive(false);
    }

    void Update()
    {
        if (transform.position.y < -5)
        {
            Debug.Log("Destroy");
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        MoveBall();
    }

    private void MoveBall()
    {
        if (PlayerColor == EBallColor.Red)
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
        }

        if (PlayerColor == EBallColor.Blue)
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
        }

        MoveDrection = new Vector3(DrectionX, 0.0f, DrectionZ);

        Rb.AddForce(MoveDrection, ForceMode.Force);
    }

    private void OnDisable()
    {
        RestartTxT.gameObject.SetActive(true);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Player")
        {
            Debug.Log("????");
        }
    }
}
