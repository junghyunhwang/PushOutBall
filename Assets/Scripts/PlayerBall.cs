using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBall : MonoBehaviour
{
    [SerializeField] private Text _RestartTxT;

    private Rigidbody rb;

    private Vector3 _MoveDrection;

    // 공 상태
    private enum PlayerState { Blue, Red}
    [SerializeField] PlayerState _PlayerState;

    private float _DrectionX = 0.0f;
    private float _DrectionZ = 0.0f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();

        _RestartTxT = GameObject.Find("RestartTxT").GetComponent<Text>();
    }

    void Start()
    {  
        _RestartTxT.gameObject.SetActive(false);
    }

    void Update()
    {
        Vector3 pos = GetComponent<Transform>().position;

        if (pos.y < -5)
        {
            Debug.Log("Destroy");
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        // 이동 호출
        MoveBall();

        /*float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 move = new Vector3(horizontal, 0, vertical);

        rb.AddForce(move, ForceMode.Force);*/
    }

    private void MoveBall()
    {
        // 뻘건공
        if (_PlayerState == PlayerState.Red)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                _DrectionX = 1f;
            }

            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                _DrectionX = -1f;
            }

            else { _DrectionX = 0.0f; }

            if (Input.GetKey(KeyCode.UpArrow))
            {
                _DrectionZ = 1f;
            }

            else if (Input.GetKey(KeyCode.DownArrow))
            {
                _DrectionZ = -1f;
            }

            else { _DrectionZ = 0.0f; }
        }

        // 퍼런공
        if (_PlayerState == PlayerState.Blue)
        {
            if (Input.GetKey(KeyCode.D))
            {
                _DrectionX = 1f;
            }

            else if (Input.GetKey(KeyCode.A))
            {
                _DrectionX = -1f;
            }

            else { _DrectionX = 0.0f; }

            if (Input.GetKey(KeyCode.W))
            {
                _DrectionZ = 1f;
            }

            else if (Input.GetKey(KeyCode.S))
            {
                _DrectionZ = -1f;
            }

            else { _DrectionZ = 0.0f; }
        }

        _MoveDrection = new Vector3(_DrectionX, 0.0f, _DrectionZ);

        // 이동
        rb.AddForce(_MoveDrection, ForceMode.Force);
    }

    private void OnDisable()
    {
        _RestartTxT.gameObject.SetActive(true);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Player")
        {
            Debug.Log("닿음");
        }
    }
}
