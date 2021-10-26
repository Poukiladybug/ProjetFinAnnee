using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float moveHorizontal;
    
    [SerializeField]
    private float movementSpeed = 3f;
    private Vector2 currentVelocity;

    private Rigidbody2D characterRigidBody;
    // Cache the Rigidbody so we don't need to keep calling it.
    private void Start()
    {
        this.characterRigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        this.moveHorizontal = Input.GetAxis("Horizontal");
       
        this.currentVelocity = this.characterRigidBody.velocity;
    }

    private void FixedUpdate()
    {
        if (this.moveHorizontal != 0)
        {
            this.characterRigidBody.velocity = new Vector2(this.moveHorizontal * this.movementSpeed, this.currentVelocity.y);
        }
    }
}
