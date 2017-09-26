using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCloseby : MonoBehaviour {
	public GetKey playerGetKey;
	public GameObject player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance(player.transform.position, gameObject.transform.position)<2f)
		{
			playerGetKey.KeyGot();
		}
		
	}
}
