using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOoB : MonoBehaviour
{
    public float leftBounds = -9;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x <-9)
        {
            Destroy(this.gameObject);
        }
    }
}
