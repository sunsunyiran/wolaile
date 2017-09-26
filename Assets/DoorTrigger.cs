using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour {
	public GameObject player;
	public OpenSesame PikaDoor;
	public GetKey gk;
	public float distance;
	public Vector3 playerpos;
	public Vector3 triggerpos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		bool playerHasKey = gk.hasGoldKey;
		playerpos = player.transform.position;
		triggerpos = gameObject.transform.position;
		distance = Vector3.Distance(
			triggerpos, playerpos);
		if (distance < 1f && playerHasKey)
		{
			PikaDoor.moveDown();
		}
	}
}
