using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Vector3 offset;
    [SerializeField] Transform player;

    private void Update()
    {
        transform.position = new Vector3(player.position.x, player.position.y + offset.y, player.position.z + offset.z);
    }
}
