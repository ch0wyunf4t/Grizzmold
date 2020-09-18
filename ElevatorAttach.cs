using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorAttach : MonoBehaviour {
    public GameObject player;
    public GameObject vator;

    void OnTriggerEnter (Collider other) {
        player.transform.parent = vator.transform;

    }
}