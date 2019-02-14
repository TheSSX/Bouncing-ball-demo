using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
    public float elapsed = 1;

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
            if (elapsed > 2.5f)
            {
                elapsed = 2.5f;
            }
        }
        else
        {
            if (elapsed != 1)
            {
                bounceit();
            }

            elapsed = 1;
        }
    }

    void bounceit()
    {
        Debug.Log("elapsed is " + elapsed);
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.AddForce(new Vector2(3, 1) * 10f * (elapsed*elapsed), ForceMode2D.Impulse);
        GameObject background = GameObject.Find("background");
        scroll scroll = background.GetComponent<scroll>();
        scroll.hasFired(elapsed*elapsed*elapsed*elapsed*elapsed*elapsed);
    }
}
