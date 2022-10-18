using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour

{
    public float speed = 5;
    private PlayerController _playerScript;
    // Start is called before the first frame update
    void Start()
    {
        _playerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    { //Don't do this for public games, make it private and have the script change it.
    // ! equals oppisite so if !_playerScript.isGameOver is = true, then !_playerScript is = false (_playerScript.isGameOver == false also works)
        if(!_playerScript.isGameOver)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        
    }
}
