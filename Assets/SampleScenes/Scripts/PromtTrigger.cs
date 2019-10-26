// Jake Buri
// PromtTrigger.cs
// Assignment 8
// Calls UIManager to display the promt at the top of the ramp

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PromtTrigger : MonoBehaviour
{
	private GameObject cube;
	public bool enter;
	public bool stay;
	public bool exit;
	public BoxCollider boxCollider;

	void Awake()
	{
		cube = GameObject.Find("Cube");

		// add isTrigger
		boxCollider = cube.GetComponent<BoxCollider>();
		boxCollider.isTrigger = true;
	}

	void Update()
	{
		if(boxCollider.isTrigger == true)
		{
			enter = true;
			stay = true;
			exit = false;
		}

		if (boxCollider.isTrigger == false)
		{
			enter = false;
			stay = false;
			exit = true;
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (enter)
		{
			UIManager.instance.DisplayPrompt();
			SpawnManager.instance.CancelBoxInvoke();
		}
	}


}
