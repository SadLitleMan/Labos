using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatControler : MonoBehaviour {

    public Camera cam;

	// Use this for initialization
	void Start () {
        if (cam == null)
        {
            cam = Camera.main;
        }
        }
	
	// Update is called once per frame
	void FixedUpdate () {
        Vector3 rawPosition = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 targetPosition = new Vector3(rawPosition.x, transform.position.y, 0.0f);
        GetComponent<Rigidbody2D>().MovePosition(targetPosition);
    }
}
