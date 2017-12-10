using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetViewer : MonoBehaviour {

    public Transform watchTarget;
	void Update () {
        transform.LookAt(watchTarget);
	}
}
