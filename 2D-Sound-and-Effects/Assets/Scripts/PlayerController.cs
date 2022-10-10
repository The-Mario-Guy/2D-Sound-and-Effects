using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 10;

    public bool isOnGround = true;

    private Rigidbody2D _playerRB;

    // Start is called before the first frame update
    void Start()
    {
        _playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    //Jumping
    {
        if(Input.GetKeyDown(KeyCode.Z) && isOnGround)
        {
            //AddForce increases the object's force
            _playerRB.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isOnGround = false;
        }
        
    }
    //If the player touches the ground it will change to True
    private void OnCollisionEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
    }
}
