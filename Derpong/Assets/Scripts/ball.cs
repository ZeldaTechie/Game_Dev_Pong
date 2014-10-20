using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {

	public GameObject spawn;
	public float speed = 10.0f;

	void move()
	{
		rigidbody2D.velocity = transform.up.normalized * speed;
	}
	void resetBall()
	{
		transform.position = spawn.transform.position;
		transform.Rotate (Vector3.forward * Random.Range(0,360));
		move();
	}

	// Use this for initialization
	void Start () {
		resetBall ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("left"))
			resetBall ();
	}
}
