using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	[SerializeField] private Rigidbody playerRigid;
	public float speed;
	public float jumpForce;
	void FixedUpdate()
	{
		float moveHorizantal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizantal, 0f, moveVertical);

		playerRigid.AddForce (movement * speed);

		if (Input.GetKeyDown (KeyCode.Space))
		{
			playerRigid.AddForce (new Vector3(0, jumpForce, 0), ForceMode.Impulse);
		}
	}
}
