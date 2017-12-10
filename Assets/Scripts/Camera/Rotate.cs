using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    public float Speed = 10f;

	void Update () {
        transform.Rotate(Vector3.up, Speed * Time.deltaTime);
	}
}
