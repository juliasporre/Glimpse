using UnityEngine;
using System.Collections;

public class treeScript : MonoBehaviour {

	public GameObject lookAt;
	
	// Update is called once per frame
	void Start () {
		transform.LookAt (lookAt.transform.position);
	}
}
