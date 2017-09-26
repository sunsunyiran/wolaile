using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class subwaycontroller : MonoBehaviour {
	public AudioClip getgun;
	public controller op;
	public bool upBool = true;
	public void disable()
	{
		gameObject.SetActive(false);
	}

	public void enable()
	{
		gameObject.SetActive(true);
	}
	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.UpArrow) && upBool)
		{
			Rigidbody rb = GetComponent<Rigidbody>();
			rb.AddForce(Vector3.up * 420);
			rb.useGravity = true;
			op.jump = false;
			upBool = false;
		}
		if (gameObject.transform.position.y < 0)
		{
			Rigidbody rb = GetComponent<Rigidbody>();
			rb.useGravity = false;
			rb.velocity = Vector3.zero;
			Vector3 pos = gameObject.transform.position;
			pos.y = 0;
			gameObject.transform.position = pos;
			upBool = true;
			op.jump = true;
		}
		if (gameObject.transform.position.z >120)
		{
			GetComponent<AudioSource>().PlayOneShot(getgun);
			SceneManager.LoadScene("scene2", LoadSceneMode.Single);


		}
	}

	void OnTriggerEnter(Collider other)
	{
		SceneManager.LoadScene("scene4", LoadSceneMode.Single);
	}
}
