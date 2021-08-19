using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 playerPosition = transform.position;
            playerPosition.z = 0.1f;
            transform.position += playerPosition;
        }
	}
}
