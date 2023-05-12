using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class script : MonoBehaviour
{
    public float playerSpeed;
    private Rigidbody2D rb;
    private Vector3 playerDirection;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        if(UDP.msg == "Up" || Input.GetKey(KeyCode.UpArrow))
        {
            playerDirection = new Vector3(0, 1).normalized;
        }
        else if (UDP.msg == "Down" || Input.GetKey(KeyCode.DownArrow))
        {
            playerDirection = new Vector3(0, -1).normalized;
        }
        else if (UDP.msg == "Left" || Input.GetKey(KeyCode.LeftArrow))
        {
            playerDirection = new Vector3(-1, 0).normalized;
        }
        else if (UDP.msg == "Right" || Input.GetKey(KeyCode.RightArrow))
        {
            playerDirection = new Vector3(1, 0).normalized;
        }
        else
        {
            playerDirection = new Vector3(0, 0).normalized;
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(transform.position + playerDirection * playerSpeed * Time.fixedDeltaTime);
    }

}