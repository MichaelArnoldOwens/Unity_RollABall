﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

  public GameObject player;
  private Vector3 offset;

	// Use this for initialization
	void Start () {
    offset = transform.position - player.transform.position;
	}
	
	// LateUpdate() is called once per frame, but only after all items are processed in Update()
	void LateUpdate () {
    transform.position = player.transform.position + offset;
  }
}
