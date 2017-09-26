using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scene2walking : MonoBehaviour {
	public GameObject player;
	public AudioClip[] footsounds;
	private UnityEngine.AI.NavMeshAgent nav;
	private AudioSource sound;
	private Animator anim;
	// Use this for initialization
	void Start()
	{
		nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
		sound = GetComponent<AudioSource>();
		anim = GetComponent<Animator>();
		nav.speed = 1.5f;
		anim.speed = 1.5f;
	}


	// Update is called once per frame
	void Update()
	{

		nav.SetDestination(player.transform.position);
	}
}