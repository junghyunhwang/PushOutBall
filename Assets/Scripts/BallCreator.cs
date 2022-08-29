using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCreator : MonoBehaviour
{
    [SerializeField] private GameObject RedBall;
    [SerializeField] private GameObject BlueBall;

    void Start()
    {
        CreateBall();
    }

    private void CreateBall()
    {
        GameObject redBall = Instantiate(RedBall);
        GameObject blueBall = Instantiate(BlueBall);

        Vector2 spawnPoisition = new Vector3(3.5f, 3f);
        redBall.transform.position = spawnPoisition;
        blueBall.transform.position = spawnPoisition * new Vector2(-1f, 1f);
    }
}
