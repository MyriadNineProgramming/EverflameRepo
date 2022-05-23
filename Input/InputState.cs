using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonState
{
    public bool value;
    public float holdTime = 0;
}

public enum Directions
{
    Right = 1,
    Left = -1
}



public class InputState : MonoBehaviour
{

    public Directions direction = Directions.Right;

    public float absVelX = 0f;
    public float absVelY = 0f;

    private Rigidbody2D rb;
    private Dictionary<Buttons, ButtonState> buttonStates = new Dictionary<Buttons, ButtonState>();

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        absVelX = Mathf.Abs(rb.velocity.x);
        absVelY = Mathf.Abs(rb.velocity.y);
    }


    public void SetButtonValue(Buttons key, bool value)
    {
        if (!buttonStates.ContainsKey(key)) 
        { 
            buttonStates.Add(key, new ButtonState());
        }

        var state = buttonStates [key];

        if(state.value && !value)
        {
            Debug.Log("Button" + key + " released");
            state.holdTime = 0;
        } 
        else if (state.value && value)
        {
            state.holdTime += Time.deltaTime;
            Debug.Log("Button " + key + " down"+state.holdTime);
        }

        state.value = value;
    }

    public bool GetButtonValue(Buttons key)
    {
        if (buttonStates.ContainsKey(key))
        {
            return buttonStates[key].value;
        } 
        else
        {
            return false;
        }
    }


}
