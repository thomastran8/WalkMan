using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    Rigidbody2D rb;
    [SerializeField]
    private float maxSpeed;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        float horMov = Input.GetAxisRaw("Horizontal") * maxSpeed;
        float factorOfMaxSpeed = maxSpeed / 3.0f;
        horMov = horMov / factorOfMaxSpeed;
        rb.velocity = new Vector2(horMov, rb.velocity.y);
    }
}
