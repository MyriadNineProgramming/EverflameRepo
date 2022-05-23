using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceBehaviour : AbstractBehaviour
{
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var right = inputState.GetButtonValue(inputButtons[0]);
        var left = inputState.GetButtonValue(inputButtons[1]);

        if (right)
        {
            Debug.Log("Facing Right");
            inputState.direction = Directions.Right;
        } else if (left)
        {
            Debug.Log("Facing Left");
            inputState.direction = Directions.Left;
        }

        transform.localScale = new Vector3((float)inputState.direction, 1, 1);

    }
}
