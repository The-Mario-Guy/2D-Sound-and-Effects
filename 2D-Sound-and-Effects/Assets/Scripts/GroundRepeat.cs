using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundRepeat : MonoBehaviour
{
    //Underscore _ for private variables
    private float _xRange =  12.12f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -_xRange)
        {
            transform.position = new Vector2(_xRange, -4.85f);
        }
    }
}