using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class layappear : MonoBehaviour {
	public GameObject lay;
	
	// Use this for initialization
	void Start () {
		lay.SetActive(false);

	}
	

	// Update is called once per frame
	void Update () {

		lay.SetActive(true);

	}
}
