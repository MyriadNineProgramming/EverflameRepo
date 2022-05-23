using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstractBehaviour : MonoBehaviour
{
    public Buttons[] inputButtons;

    protected InputState inputState;
    protected Rigidbody2D rb;

    protected virtual void Awake()
    {
        inputState = GetComponent<InputState>();
        rb = GetComponent<Rigidbody2D>(); 
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
