using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 10;
    
    float horizontalInput;
    public Bullet bulletPref;
    public Transform shootingPoint;
    private Vector3 moveDir;
    private Quaternion flipped = new Quaternion(0, 180, 0, 0);
    private Quaternion regular = new Quaternion(0, 0, 0, 0);


    private void Update()
    {
        PlayerInput();
        PlayerMovement();
        if (Input.GetMouseButtonDown(0))
        {
            var tempBullet = Instantiate(bulletPref, shootingPoint.position, transform.rotation);
            tempBullet.bulletAddforce(moveDir);
        }
    }

    void PlayerMovement()
    {
        moveDir = new Vector3(horizontalInput, 0);
        Debug.Log(moveDir);
        transform.position += moveDir * speed * Time.deltaTime;

        if (horizontalInput > 0)
        {
            transform.rotation = flipped;
        }
        else
            transform.rotation = regular;
    }

    void PlayerInput()
    {
        horizontalInput = Input.GetAxis("Horizontal");
    }
}
