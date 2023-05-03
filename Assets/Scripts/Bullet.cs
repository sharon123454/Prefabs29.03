using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    PlayerController PlayerCon;
    Vector2 vector2;
    public float speed;
    private Rigidbody2D rb;

    private void Start()
    {
        //Vector2 vc2 = new Vector2 (PlayerCon.moveDir.x, 0);
        rb = GetComponent<Rigidbody2D>();
        //rb.AddForce(vc2 * speed);
    }
}
