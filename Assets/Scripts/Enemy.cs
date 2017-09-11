using UnityEngine;

public class Enemy : MonoBehaviour {

    public float minSpeed = -25f;
    public float maxSpeed = -5f;

    Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();

        rb.velocity = new Vector2(Random.Range(minSpeed, maxSpeed), 0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
