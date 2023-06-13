using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class FJet : MonoBehaviour {

	[SerializeField] string triggeringTag;
	public GameObject explosion;

	public float speed = 1f;
	public float rotateSpeed = 200f;

	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}

	private void Update()
	{
		float horizontal = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
		float vertical = Input.GetAxis("Vertical") * speed * Time.deltaTime;

		transform.Translate(horizontal, vertical, 0f);
	}

	    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag && enabled) {
			Instantiate (explosion, rb.position, Quaternion.identity);
            Destroy(this.gameObject);
			SceneManager.LoadScene("Restart");
			
        }
	// 	void OnTriggerEnter2D ()
	// {
	// 	Instantiate (explosion, rb.position, Quaternion.identity);
	// 	Destroy(gameObject);
	// }
		}
}