using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguinController : MonoBehaviour
{
    public float walkingSpeed = 1;
    private float jumpingSpeed = 1;
    private float animationFPS = 5;
    Rigidbody2D rb2D;
    private float movementVertical;
    private float movementHorizontal;

    void Start()
    {
        movementVertical = 0;
        movementHorizontal = walkingSpeed;
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        

        rb2D.velocity = new Vector2(movementHorizontal, movementVertical);

        if (Input.GetKey(KeyCode.Space))
        {
            movementVertical = jumpingSpeed;
        }

    }
}
