using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : AbstractBehaviour
{

    public float speed = 300f;
    public float runMultiplier = 2f;
    
    

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var right = inputState.GetButtonValue(inputButtons[0]);
        var left = inputState.GetButtonValue(inputButtons[1]);
        var run = inputState.GetButtonValue(inputButtons[2]);

        if(right || left)
        {
            var tSpeed = speed;

            if(run && runMultiplier > 0)
            {
                tSpeed *= runMultiplier;
            }

            var velX = tSpeed * (float)inputState.direction;

            rb.velocity = new Vector2(velX, rb.velocity.y);
        }

    }
}
