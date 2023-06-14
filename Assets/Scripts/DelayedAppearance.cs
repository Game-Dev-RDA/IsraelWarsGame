using System.Collections;
using UnityEngine;

public class DelayedAppearance : MonoBehaviour
{
    public float delay = 200f; // Delay in seconds
    public Renderer objectRenderer; // Reference to the object's Renderer component
    public GameObject explosion;
    [SerializeField] string triggeringTag;


	private Rigidbody2D rb;

    private void Start()
    {
        objectRenderer.enabled = false; // Disable the object's renderer initially
        StartCoroutine(EnableRendererAfterDelay());
        rb = GetComponent<Rigidbody2D>();
    }

    IEnumerator EnableRendererAfterDelay()
    {
        yield return new WaitForSeconds(delay);

        // Enable the object's renderer to make it visible on the screen
        objectRenderer.enabled = true;
    }

	    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag && enabled) {
			Instantiate (explosion, rb.position, Quaternion.identity);
			
        }}
}
