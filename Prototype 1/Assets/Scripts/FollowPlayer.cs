using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform playerTransform;


    Vector3 positionOffset = new Vector3(0, 5, -7);


    private void FixedUpdate()
    {
        // Update camera position to follow player.
        transform.position = playerTransform.position + positionOffset;
    }
}
