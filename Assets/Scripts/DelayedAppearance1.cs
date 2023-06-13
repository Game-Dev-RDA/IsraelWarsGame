using System.Collections;
using UnityEngine;

public class DelayedAppearance1 : MonoBehaviour
{
    public float delay = 200f; // Delay in seconds
    public Renderer objectRenderer1; // Reference to the object's Renderer component
    public Renderer objectRenderer2;


	private Rigidbody2D rb;

    private void Start()
    {
        objectRenderer1.enabled = false; // Disable the object's renderer initially
        objectRenderer2.enabled = false;
        StartCoroutine(EnableRendererAfterDelay());
        rb = GetComponent<Rigidbody2D>();
    }

    IEnumerator EnableRendererAfterDelay()
    {
        yield return new WaitForSeconds(delay);

        // Enable the object's renderer to make it visible on the screen
        objectRenderer1.enabled = true;
        objectRenderer2.enabled = true;
    }

    // 	    private void OnTriggerEnter2D(Collider2D other) {
    //     if (other.tag == triggeringTag && enabled) {
	// 		Instantiate (explosion, rb.position, Quaternion.identity);
    //         Destroy(this.gameObject);
    //         // Destroy(other.gameObject);
			
    //     }
    // }
}
