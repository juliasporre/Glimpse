using UnityEngine;
using System.Collections;

public class treeScript : MonoBehaviour {
	
	// Update is called once per frame
	void Start () {
		transform.LookAt (GameObject.Find("woodenframe2").transform.position);
	}
}
