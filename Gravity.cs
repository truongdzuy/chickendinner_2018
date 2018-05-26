using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour {

    public float gravitationalPull;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate()
    {
        //or apply gravity to all game objects with rigidbody
        foreach (GameObject o in UnityEngine.Object.FindObjectsOfType<GameObject>())
        {
            if (o.GetComponent<Rigidbody>() && o != gameObject)
            {
                o.GetComponent<Rigidbody>().AddForce((transform.position - o.transform.position).normalized * gravitationalPull);
            }
        }
    }
}
