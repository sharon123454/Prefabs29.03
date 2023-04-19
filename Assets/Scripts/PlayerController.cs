using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 10;
    
    float horizontalInput;

    private Vector3 moveDir;


    private void Update()
    {
        PlayerInput();
        PlayerMovement();
    }

    void PlayerMovement()
    {
        moveDir = new Vector3(horizontalInput, 0);
        Debug.Log(moveDir);
        transform.position += moveDir;
    }

    void PlayerInput()
    {
        horizontalInput = Input.GetAxis("Horizontal");
    }
}
