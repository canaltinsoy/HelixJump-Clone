using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    private GameObject ball;
    private Transform ballTransform;

    private Vector3 offset;

    public float lerpSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        GameObject ball = GameObject.Find("Ball");
        ballTransform = ball.GetComponent<Transform>();

        offset = transform.position - ballTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = Vector3.Lerp(transform.position, ballTransform.position + offset, lerpSpeed);
        transform.position = newPos;
    }
}
