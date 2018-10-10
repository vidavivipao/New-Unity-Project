using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moon : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Transform transform = GetComponent<Transform>();
        Vector3 angle = new Vector3(0, 0.4f, 0);
        transform.Rotate(angle);
    }
}
