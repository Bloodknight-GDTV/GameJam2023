using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalKeybinds : MonoBehaviour
{
    
    bool isActiveDimension1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void SwitchDimensions()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (isActiveDimension1)
            {
                
            }
            else
            {
                
            }
            
        }
        
    }
    
    private void MoveForward()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            // move forward
        }
        else
        {
            // stop moving forward
        }
    }
    
    private void MoveBackward()
    {
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            // move backward
        }
        else
        {
            // stop moving backward
        }
    }
}
