using UnityEngine;
using System.Collections;

public class Sping : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.Rotate (10.0f * Time.deltaTime, 20f * Time.deltaTime , 0);
	}
}
