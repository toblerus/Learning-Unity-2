using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

	[SerializeField] private float rotX;
	[SerializeField] private float rotY;
	[SerializeField] private float rotZ;

	void Update () {
		transform.Rotate (new Vector3 (rotX, rotY, rotZ) * Time.deltaTime);
	}
}
