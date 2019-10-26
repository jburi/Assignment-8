// Jake Buri
// UIManager.cs
// Assignment 8
// Function to display the promt

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager: MonoBehaviour
{
	//Create Instance and Get canvas
	public static UIManager instance;
	private GameObject canvas;
	public float timer = 0.0f;

	void Awake()
	{
		instance = this;
		canvas = GameObject.Find("Canvas");
	}
	//Displays the promt when called
	public void DisplayPrompt()
	{
		canvas.SetActive(true);
		StartCoroutine("Timer");
	}

	public IEnumerator Timer()
	{
		yield return new WaitForSeconds(5);
		canvas.SetActive(false);
	}
}