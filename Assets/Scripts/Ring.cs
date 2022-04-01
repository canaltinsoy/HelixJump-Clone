using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring : MonoBehaviour
{
    public Transform ball;
    private GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameManager.FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y + 17f >= ball.position.y)
        {
            Destroy(gameObject);
            gm.IncreaseGameScore(10);
        }
    }
}
