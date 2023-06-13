using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class HomingMissile : MonoBehaviour {

	public Transform target;
	public static Vector2 positionF;
	public GameObject explosion;

	public float speed = 5f;
	public float rotateSpeed = 200f;

	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		positionF = target.position;
	}
	
	void FixedUpdate () {
		Vector2 direction = (Vector2)positionF - rb.position;

		direction.Normalize();

		float rotateAmount = Vector3.Cross(direction, transform.up).z;

		rb.angularVelocity = -rotateAmount * rotateSpeed;

		rb.velocity = transform.up * speed;
	}

	// void OnTriggerEnter2D ()
	// {
	// 	Instantiate (explosion, rb.position, Quaternion.identity);
	// 	Destroy(gameObject);
	// }
}
