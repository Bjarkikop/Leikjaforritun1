﻿using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //Geri public breytur fyrir PLayer og vector
    public Transform player;
    public Vector3 offset;
    void Update()
    {
        // læt myndavél fylgja PLayer
        transform.position = player.position + offset;
    }
}