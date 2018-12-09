using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveplayer : MonoBehaviour {
    public float playerspeed;
  
    
	// Use this for initialization
	void Start () {
        playerspeed = 600f;
	}
	
	// Update is called once per frame
	void Update () {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        GetComponent<Rigidbody>().AddForce(movement * playerspeed * Time.deltaTime);
    }

    
}
