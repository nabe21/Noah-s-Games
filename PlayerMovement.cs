using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * 15f * Time.deltaTime, 0f, 0f);
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("Left Arrow");
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("Right Arrow");
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("A");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("D");
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space");
            transform.Translate(Input.GetAxis("Vertical") * 0f, 400f * Time.deltaTime, 0f);
        }
    }
}
