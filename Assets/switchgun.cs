using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class switchgun : MonoBehaviour {
	public int playerlife = 100;
	public Text txt;
	public GameObject weapon1;
	public GameObject weapon2;
	public GameObject bulletPrefab;
	public GameObject bulletPrefab2;

	// Use this for initialization
	void Start () {
		weapon1.SetActive(true);
		weapon2.SetActive(false);
		bulletPrefab.SetActive(true);
		bulletPrefab2.SetActive(false);

}
	
	// Update is called once per frame
	void Update () {
		txt.text = "Your Life:" + " " + playerlife;
		if (Input.GetKeyDown("1"))
		{
			weapon1.SetActive(true);
			weapon2.SetActive(false);
			bulletPrefab.SetActive(true);
			bulletPrefab2.SetActive(false);
		}
		if (Input.GetKeyDown("2"))
		{
			weapon1.SetActive(false);
			weapon2.SetActive(true);
			bulletPrefab.SetActive(false);
			bulletPrefab2.SetActive(true);
		}
		
	}
}
