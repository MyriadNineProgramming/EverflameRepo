using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 20;
    public Buttons[] input;

    private Rigidbody2D rb;
    private InputState inputState;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        inputState = GetComponent<InputState>();
    }

    // Update is called once per frame
    void Update()
    {
        var right = inputState.GetButtonValue(input[0]);
        var left = inputState.GetButtonValue(input[1]);

        var velX = speed;

        if (left || right)
        {
            velX *= left ? -1 : 1;
        }
        else
        {
            velX = 0;
        }

        rb.velocity = new Vector2(velX * speed, rb.velocity.y);
    }

    


}
