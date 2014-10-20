using UnityEngine;
using System.Collections;

public class paddle : MonoBehaviour {

	void move()
	{
		transform.Translate (Input.GetAxis("Horizontal") * 10* Time.deltaTime, 0 , 0);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		move();
	}
}
