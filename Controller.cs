using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
    public GameObject owner;
    public GameObject planer;
    public float offset;
	// Use this for initialization
	void Start () {
        
        

    }
	
	// Update is called once per frame
	void Update () {

        Vector3 n = (owner.transform.position - planer.transform.position).normalized;
        Vector3 pos = n * offset;
        transform.LookAt(planer.transform.position);
        transform.position = pos;

    }
}
