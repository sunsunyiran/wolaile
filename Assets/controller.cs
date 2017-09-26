using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour {

	public subwaycontroller right;
	public subwaycontroller middle;
	public subwaycontroller left;

	public bool jump;
	enum Position { left, middle, right };
	Position loc = Position.right;
	// Use this for initialization


	void Start()
	{
		jump = true;

	}



	// Update is called once per frame
	void Update()
	{
		Vector3 pos = gameObject.transform.position;
		pos.z = pos.z + 0.1f;
		gameObject.transform.position = pos;

		if (Input.GetKeyDown(KeyCode.LeftArrow) && jump == true)
		{
			if (loc == Position.right)
			{
				loc = Position.middle;
			}
			else if (loc == Position.middle)
			{
				loc = Position.left;
			}
		}

		if (Input.GetKeyDown(KeyCode.RightArrow) && jump == true)
		{
			if (loc == Position.middle)
			{
				loc = Position.right;
			}
			if (loc == Position.left)
			{
				loc = Position.middle;
			}
		}



		if (loc != Position.right)
		{
			right.disable();
		}
		if (loc != Position.middle)
		{
			middle.disable();
		}
		if (loc != Position.left)
		{
			left.disable();
		}


		if (loc == Position.right)
		{
			right.enable();
		}
		if (loc == Position.middle)
		{
			middle.enable();
		}
		if (loc == Position.left)
		{
			left.enable();
		}

	}
}
