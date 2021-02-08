using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour{
    Vector3 originalPos;

    void Start()
    {
        gameObject.tag = "Player";
        originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);

    }
    private void OnTriggerEnter2D(Collider2D other){
        if (other.tag == "Collider")
        {
            Debug.Log("hit detected");
            transform.localScale = new Vector3(1, 1, 1);
            gameObject.transform.position = originalPos;

        }


    }

}
