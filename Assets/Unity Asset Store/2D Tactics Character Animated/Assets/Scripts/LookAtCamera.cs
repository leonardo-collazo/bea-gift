using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Author: Alan Pereira (AsuraBrasil @ GitHub // AlanPereiraArt @ Instagram)
public class LookAtCamera : MonoBehaviour {

    private Transform camTransform;

	void Start ()
    {
        camTransform = GameObject.FindGameObjectWithTag("MainCamera").transform;
	}

	void Update ()
    {
        transform.LookAt(camTransform);
	}

}//END LookAtCamera.cs
