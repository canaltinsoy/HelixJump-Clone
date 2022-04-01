using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody rb;

    public float jumpForce;

    public GameObject splashPrefab;

    private GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        gm = GameObject.FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        
        rb.velocity = new Vector3(0, jumpForce, 0);

        GameObject splash = Instantiate(splashPrefab, transform.position - new Vector3(0,0.2f,0), Quaternion.Euler(90,0,0));
        splash.transform.SetParent(other.gameObject.transform);

        //rb.AddForce(Vector3.up * jumpForce);

        string materialName = other.gameObject.GetComponent<MeshRenderer>().material.name;

        print(materialName);

        if(materialName == "PlatformDanger (Instance)")
        {
            gm.Restart();
            //game over
        }
        else if(materialName == "PlatformSafe (Instance)")
        {
            //restart
            
        }
        else if(materialName == "PlatformLast (Instance)")
        {
            //next level
            gm.Congrats();
        }


    }
}
