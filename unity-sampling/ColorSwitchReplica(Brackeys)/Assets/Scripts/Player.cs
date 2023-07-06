using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float jumpForce = 10f;
    public Rigidbody2D rb;

    // void Update()
    // {

    // }

    public void ButtonOnClick() {
        rb.velocity = Vector2.up * jumpForce;
    }
}
