using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOoB : MonoBehaviour
{
    public float leftBounds = -9;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x <-9)
        {
            Destroy(this.gameObject);
        }
    }
}