using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform shootingPoint;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, shootingPoint.position, transform.rotation);
        }
    }
}