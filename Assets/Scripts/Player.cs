using System;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float horizentalSpeed;
    private float verticalSpeed;
    private Vector3 moveDir;
    private Rigidbody2D rb;
    
    [SerializeField]
    private float speed = 5f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizentalSpeed = Input.GetAxis("Horizontal");
        verticalSpeed = Input.GetAxis("Vertical");
        moveDir = new Vector2(horizentalSpeed, verticalSpeed).normalized /** speed*/;
    }
    

    private void FixedUpdate()
    {
        // transform.position += moveDir * Time.fixedDeltaTime;
        rb.linearVelocity = moveDir * speed;
        // rb.AddForce(moveDir * speed, ForceMode2D.Force);
    }
}
