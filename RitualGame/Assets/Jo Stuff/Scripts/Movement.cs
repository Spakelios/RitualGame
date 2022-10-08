using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Vector2 playerMovement;
    public Rigidbody2D playerRB;
    public float movementSpeed;
    public bool canMove;
    void Start()
    {
        canMove = true;
        playerRB = GetComponent<Rigidbody2D>();
        playerRB.gravityScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!canMove)
        {
            return;
        }

        playerMovement.x = Input.GetAxisRaw("Horizontal");
        playerMovement.y = Input.GetAxisRaw("Vertical");
        
        playerRB.MovePosition(playerRB.position + playerMovement * (movementSpeed * Time.fixedDeltaTime));
    }
}
