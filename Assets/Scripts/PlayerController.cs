using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
	[SerializeField] private Rigidbody playerRigid;
    [SerializeField] private float initialSpeed;
    [SerializeField] CollectablesManager collectablesManager;
	public float speed;
	public float jumpForce;
    public float sprintSpeed;
    public Text leftPickUpsText;
    public Text winText;


	void FixedUpdate()
	{
		float moveHorizantal = Input.GetAxis ("Horizontal"); //Movement
        float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizantal, 0f, moveVertical);

		playerRigid.AddForce (movement * speed); 


        if (Input.GetKeyDown (KeyCode.Space)) //Jumping
		{
			playerRigid.AddForce (new Vector3(0, jumpForce, 0), ForceMode.Impulse);
		}

        if (Input.GetKey (KeyCode.LeftShift)) //Sprinting
        {
            speed = sprintSpeed;
        }
        else
        {
            speed = initialSpeed;
        }

	}


    void OnTriggerEnter(Collider other) //Collecting
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            collectablesManager.TotalCollectablesAmount--;
            leftPickUpsText.text = "Left: " + collectablesManager.TotalCollectablesAmount.ToString(); //updates leftover display
            if (collectablesManager.TotalCollectablesAmount == 0)
            {
                winText.text = "You win!";
            }
        }


    }
}
