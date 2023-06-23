using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdJump : MonoBehaviour
{

    public float jumpPower;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // left button click
        if (Input.GetMouseButtonDown(0)) {
            rb.velocity = Vector2.up * jumpPower; // (0, 3)
        }
    }
}
