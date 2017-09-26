using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
	public Transform player;
	int walking = 0;
	// Use this for initialization
	void Start () {
		GetComponent<Animator>().SetBool("isWalking", true);
		
	}
	
	// Update is called once per frame
	void Update () {
		


			transform.LookAt(player);
			transform.Translate(Vector3.forward * Time.deltaTime);
		
		
	}
}
