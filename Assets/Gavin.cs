using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gavin : MonoBehaviour {

	public float FloorHeight;
	public float Speed;
	private Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		// Stops player from falling through floor
		if (rb.position.y <= FloorHeight) rb.MovePosition (new Vector2 (rb.position.x, FloorHeight));

		// Allows player to move
		float hSpeed = Input.GetAxis("Horizontal") * Speed;

		rb.AddForce (new Vector2 (hSpeed, 0));
	}
}
