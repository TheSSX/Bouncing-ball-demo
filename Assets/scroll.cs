using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll : MonoBehaviour {

    public float speed;
    Vector2 offset;

    // Use this for initialization
    void Start () {
        speed = 5f;
	}
	
	// Update is called once per frame
	void Update () {
        speed -= 0.002f;

        if (speed >= 0)
        {
            offset = new Vector2(Time.time * speed, 0);

            Renderer renderer = GetComponent<Renderer>();
            renderer.material.mainTextureOffset = offset;
        }
        else
        {
            speed = 0;
            Renderer renderer = GetComponent<Renderer>();
            renderer.material.SetTextureOffset("new", renderer.material.GetTextureOffset("background"));
        }
	}
}
