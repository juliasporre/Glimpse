using UnityEngine;
using System.Collections;

public class explode_and_die : MonoBehaviour {
	public float radius = 10.0F;
	public float power = 10.0F;
	public GameObject explosionObject = null;
	private bool called = false;
	// Use this for initialization
	void Start () {

	}
		
	// Update is called once per frame
	void Update () {
		if (!called && Input.GetKey (KeyCode.Space)) {
			called = true;
			foreach (Transform child in transform) {
				Rigidbody rb = child.GetComponent<Rigidbody> ();
				if (rb != null)
					rb.useGravity = true;
			}
			Vector3 explosionPos = explosionObject.transform.position;
			Collider[] colliders = Physics.OverlapSphere (explosionPos, radius);
			foreach (Collider hit in colliders) {
				Rigidbody rb = hit.GetComponent<Rigidbody> ();

				if (rb != null)
					rb.AddExplosionForce (power, explosionPos, radius, 10.0F);

			}
			print ("Before");
			Invoke ("DestroyObjectPre", 1);
		}
	}

	void DestroyObjectPre() {
		StartCoroutine (DestroyObject ());
	}
	IEnumerator DestroyObject() {
		foreach (Transform child in transform) {
			Renderer r = child.GetComponent<Renderer> ();
			if (r != null)
				r.enabled = false;
			yield return new WaitForSeconds (0.05f);
		}
		DestroyImmediate(this.gameObject);
	}

}
