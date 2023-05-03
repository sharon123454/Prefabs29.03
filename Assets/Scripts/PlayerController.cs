using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine.Unity;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 10;
    [SerializeField] float timeToIdle = 0.8f;
    [SerializeField] SkeletonAnimation skeletonAnimation;
    
    public Bullet bulletPref;
    public Transform shootingPoint;

    private float horizontalInput;
    private Vector3 moveDir;
    private Quaternion flipped = new Quaternion(0, 180, 0, 0);
    private Quaternion regular = new Quaternion(0, 0, 0, 0);

    private void Update()
    {
        PlayerInput();
        PlayerMovement();
        Shooting();
    }

    private void Shooting()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var tempBullet = Instantiate(bulletPref, shootingPoint.position, transform.rotation);
            tempBullet.bulletAddforce(moveDir.normalized);
            skeletonAnimation.AnimationName = "ATTACK";
            print("attack pressed");
            StopCoroutine(ChangeToIdle());
            StartCoroutine(ChangeToIdle());
        }
        
    }

    private IEnumerator ChangeToIdle()
    {
        yield return new WaitForSeconds(timeToIdle);
        skeletonAnimation.AnimationName = "IDLE";
    }

    void PlayerMovement()
    {
        moveDir = new Vector3(horizontalInput, 0);
        Debug.Log(moveDir);
        transform.position += moveDir * speed * Time.deltaTime;

        if (horizontalInput > 0)
        {
            transform.rotation = flipped;
            skeletonAnimation.AnimationName = "WALK";
        }
        else if (horizontalInput < 0)
        {
            transform.rotation = regular;
            skeletonAnimation.AnimationName = "WALK";
        }
        //else
            //skeletonAnimation.AnimationName = "IDLE";


    }

    void PlayerInput()
    {
        horizontalInput = Input.GetAxis("Horizontal");
    }
}
