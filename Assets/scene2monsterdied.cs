using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scene2monsterdied : MonoBehaviour {
	public int monstersLife = 100;
	GameObject monster;
	
	

	// Use this for initialization
	void Start () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		
		
			TakeDamage1();
		
		
	}

	public void TakeDamage1()
	{
		monstersLife = monstersLife - 10;
	}
	
	// Update is called once per frame
	void Update () {
		if (monstersLife == 0)
		{
			Destroy(gameObject);
		}
	}
}
