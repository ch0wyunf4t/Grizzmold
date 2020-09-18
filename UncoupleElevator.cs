using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UncoupleElevator : MonoBehaviour
{
    public GameObject player;
    public GameObject vator;

    void OnTriggerEnter(Collider other)
    {
        player.transform.parent = null;
    }

}