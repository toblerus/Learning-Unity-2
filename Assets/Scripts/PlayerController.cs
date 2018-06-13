using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public Rigidbody playerRigid; //Why would I let it search for the rigidbody via getcomponent<Rigidbody>(); and not just let me add it in the inspector (which i did)?
	public float speed;

	void FixedUpdate()
	{
		float moveHorizantal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizantal, 0f, moveVertical);

		playerRigid.AddForce (movement * speed);
	}
}
