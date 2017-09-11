using UnityEngine;

public class PlayerScript : MonoBehaviour {

    public bool amIDead = false;

    public float hitPoints = 10f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0))
        {
            transform.position = 
                new Vector3(transform.position.x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, transform.position.z);
        }
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (amIDead)
        {
            return;
        }

        amIDead = true;
    }
}
