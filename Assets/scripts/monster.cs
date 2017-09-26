using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class monster : MonoBehaviour {
	public GameObject player;
	public AudioClip[] footsounds;
	private NavMeshAgent nav;
	private AudioSource sound;
	private Animator anim;
	// Use this for initialization
	void Start ()
	{
		nav = GetComponent<NavMeshAgent>();
		sound = GetComponent<AudioSource>();
		anim = GetComponent<Animator>();
		nav.speed = 1.2f;
		anim.speed = 1.2f;
	}
	public void footstep(int _num)
	{
		sound.clip = footsounds[_num];
		sound.Play();
	}
	
	// Update is called once per frame
	void Update ()
	{
		anim.SetFloat("velocity", nav.velocity.magnitude);
		nav.SetDestination(player.transform.position);
	}
}
