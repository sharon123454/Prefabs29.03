using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    PlayerController PlayerCon;
    Vector2 vector2 = Vector2.right;
    public float speed;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        tempTest();
    }


    public void bulletAddforce(Vector2 vc2)
    {
        if (vc2 != Vector2.zero)
        {
            vector2 = vc2;
        }
    }

    private void tempTest()
    {
        rb.AddForce(vector2 * speed);
    }
}
