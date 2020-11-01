using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerMovement : MonoBehaviour
{

    [SerializeField] public GameObject player;
    [SerializeField] public Vector3 positionShift;


    void Update()
    {

        if (player.transform.position.x < 31f)
        {
            transform.position = new Vector3(
                player.transform.position.x + positionShift.x,
                player.transform.position.y + positionShift.y,
                player.transform.position.z + positionShift.z);
        }
    }
}
