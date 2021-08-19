using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale_Cube : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	// Update is called once per frame
	void Update () {
                // si la touche W est appuyee
        if (Input.GetKeyDown(KeyCode.W))
        {
            // si le cube a un scale superieur a 1 (ne pas effectuer un scale au dessus de 5)
            if (transform.localScale.x < 1 && transform.localScale.y < 1 && transform.localScale.z < 1)
            {
                // alors faire une transformation scale incrementee sur le gameobject
                transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
            }
        }
        // si la touche W est appuyee
        if (Input.GetKeyDown(KeyCode.X))
        {
            // si le cube a un scale superieur a 0 (ne pas effectuer un scale negatif)
            if (transform.localScale.x > 0 && transform.localScale.y > 0 && transform.localScale.z > 0)
            {
                // alors faire une transformation scale decrementee sur le gameobject
                transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
            }
        }
		
	}
}
