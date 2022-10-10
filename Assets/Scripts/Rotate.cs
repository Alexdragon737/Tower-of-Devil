using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    public float speed = 5f;
	
	void Start () {
		
	}
	

	void Update () {
        transform.Rotate(speed, 0, 0);
	}
}
