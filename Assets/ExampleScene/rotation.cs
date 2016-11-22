using UnityEngine;
using System.Collections;

public class rotation : MonoBehaviour {


	public float torque;
	public Rigidbody rb;
	void Start() {
		rb = GetComponent<Rigidbody>();
		rb.AddTorque(transform.up * torque);
	}
	void FixedUpdate() {
		

	}
}
