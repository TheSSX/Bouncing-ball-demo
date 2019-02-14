using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
    public float elapsed = 0;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKey(KeyCode.Space)))
        {
            elapsed += Time.deltaTime;
            if (elapsed > 1.5f)
            {
                elapsed = 1.5f;
            }
        }
        else
        {
            if (elapsed != 0)
            {
                bounceit();
            }

            elapsed = 0;
        }
    }

    void bounceit()
    {
        Debug.Log("elapsed is " + elapsed);
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.AddForce(new Vector2(0.5f, 1) * 1000f * (elapsed*elapsed));
        GameObject background = GameObject.Find("background");
        scroll scroll = background.GetComponent<scroll>();
        scroll.hasFired(elapsed*elapsed*elapsed);
    }
}
