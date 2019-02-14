using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nobelowground : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < 0.9)
        {
            transform.position = new Vector2(0, 0.9f);
        }
	}
}
