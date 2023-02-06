using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguinController : MonoBehaviour
{
    public float speed;
    //Rigidbody2D rb2D;

    void Start()
    {
        //rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float movementVertical = 0;
        if (Input.GetKey(KeyCode.Space)) { movementVertical = speed; }

    }
}
