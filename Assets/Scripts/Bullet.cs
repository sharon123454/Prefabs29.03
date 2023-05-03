using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{ 
    [SerializeField] private  float timeTillDeath = 5;

    private Quaternion flipped = new Quaternion(0, 180, 0, 0);
    private Quaternion regular = new Quaternion(0, 0, 0, 0);
    Vector2 vector2 = Vector2.right;
    public float speed;
    private Rigidbody2D rb;
    float timer;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(vector2 * speed);
    }

    public void bulletAddforce(Vector2 vc2)
    {
        timer = timeTillDeath;

        if (vc2.normalized.x > 0)
        {
            transform.rotation = flipped;
            vector2 = vc2;
        }
        else if (vc2.normalized.x < 0)
        {
            transform.rotation = regular;
            vector2 = vc2;
        }
        else
        {
            vector2 = Vector2.right;
        }
    }

    private void Update()
    {
        timer -= Time.deltaTime;

        if (timer < 0)
            Destroy(gameObject);
    }
}
