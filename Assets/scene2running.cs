using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class scene2running : MonoBehaviour {

	public GameObject player;
	public AudioClip[] footsounds;
	private NavMeshAgent nav;
	private AudioSource sound;
	private Animator anim;
	// Use this for initialization
	void Start()
	{
		nav = GetComponent<NavMeshAgent>();
		sound = GetComponent<AudioSource>();
		anim = GetComponent<Animator>();
		nav.speed = 3.5f;
		anim.speed = 1.0f;
	}


	// Update is called once per frame
	void Update()
	{

		nav.SetDestination(player.transform.position);
	}
}