using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 10;
    public bool isOnGround = false;
    
    public bool isGameOver = false;

    private Rigidbody2D _playerRB;
    private Animator _playerAnim;

    // Start is called before the first frame update
    void Start()
    {
        _playerRB = GetComponent<Rigidbody2D>();
        _playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //&& is "and" ! is oppisite so game over needs to be false to jump
        if(Input.GetKeyDown(KeyCode.Z) && isOnGround && !isGameOver)
        {
            _playerRB.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isOnGround = false;
            //Lets the game know to switch to the "Jump" Animation
            _playerAnim.SetBool("IsOnGround", isOnGround);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            //Lets the game know to switch to the "Walk" Animation
            _playerAnim.SetBool("IsOnGround", isOnGround);
        }
        else if(other.gameObject.CompareTag("Obstacle"))
        {
            isGameOver = true;
            _playerAnim.SetBool("IsGameOver", isGameOver);
        }
    }
}