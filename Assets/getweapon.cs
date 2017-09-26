using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getweapon : MonoBehaviour {
	public AudioClip getgun;
	// Use this for initialization
	void Start () {
		
	}
	public void OnTriggerEnter(Collider other)
	{
		GetComponent<AudioSource>().PlayOneShot(getgun);
	}


	// Update is called once per frame
	void Update () {
		
	}
}
