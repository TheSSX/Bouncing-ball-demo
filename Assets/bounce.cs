using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class bounce : MonoBehaviour {

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        GameObject player = GameObject.Find("player");
        if (player.transform.position.y <= -12)
        {
            GameObject background = GameObject.Find("background");
            scroll scroll = background.GetComponent<scroll>();
            changeSpeed(scroll.speed);
        }
    }

    void changeSpeed(float speed)
    {
        GameObject background = GameObject.Find("background");
        Renderer renderer = background.GetComponent(typeof(Renderer)) as Renderer;
        Vector2 offset = new Vector2(Time.time * speed, 0);
        renderer.material.mainTextureOffset = offset;
    }
}
