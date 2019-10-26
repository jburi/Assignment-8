// Jake Buri
// SpawnManager.cs
// Assignment 8
// Makes boxes rain

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
	public static SpawnManager instance;
	public GameObject myPrefab;
	public GameObject player;
	public float playerX;
	public float playerY;
	public float playerZ;

	void Awake()
	{
		instance = this;
	}

	void Start()
    {
		if(player ==null)
		{
			player = GameObject.Find("ThirdPersonController");
		}

		InvokeRepeating("SpawnBox", 2, 2);
	}

    void Update()
    {
		playerX = player.transform.position.x;
		playerY = player.transform.position.y;
		playerZ = player.transform.position.z;
	}

	void SpawnBox()
	{
		GameObject instance = Instantiate(myPrefab, new Vector3(Random.Range(playerX - 5, playerX + 5),
			Random.Range(playerY + 20, playerX + 50), Random.Range(playerZ - 5, playerZ + 5)), Quaternion.identity);
	}

	public void CancelBoxInvoke()
	{
		CancelInvoke("SpawnBox");
	}
}
