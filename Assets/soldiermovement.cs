using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class soldiermovement : MonoBehaviour {
	public Transform player1;
	
	
	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(player1);
		transform.Translate(Vector3.forward * Time.deltaTime);
		
	}
}
