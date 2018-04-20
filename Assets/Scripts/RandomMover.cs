using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMover : MonoBehaviour {
    HingeJoint2D hinge = null;
    // Use this for initialization
    void Start () {
     hinge = gameObject.GetComponent(typeof(HingeJoint2D)) as HingeJoint2D;
    }
	
	// Update is called once per frame
	void Update () {
	}
}
