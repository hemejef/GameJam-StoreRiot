using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {
    [SerializeField]
    float distanceFromPlayer;
    Transform playerTr;
	// Use this for initialization
	void Start () {
        playerTr = GameObject.FindGameObjectWithTag("Player").transform;	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3 (playerTr.position.x, playerTr.position.y + distanceFromPlayer, playerTr.position.z);
	}
}
