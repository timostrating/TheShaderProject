using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
    [SerializeField]
    Vector3 rotation;
    Transform myTransform;


    void Start() {
        myTransform = transform;
    }

    void Update () {
		myTransform.Rotate(rotation);
	}
}
