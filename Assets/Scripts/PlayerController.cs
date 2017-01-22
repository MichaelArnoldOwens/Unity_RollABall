using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

  public float speed;

  private Rigidbody rb;

  // Called automatically when script is loaded
  void Start() {
    // Access Rigidbody component on the same game object
    rb = GetComponent<Rigidbody>();
  }

  // Called before rendering a frame
  void Update() {
    
  }

  // Called before physics calculations
  void FixedUpdate() {
    float moveHorizontal = Input.GetAxis("Horizontal");
    float moveVertical = Input.GetAxis("Vertical");

    Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);

    rb.AddForce(movement * speed);
  }

  // OnTriggerEnter is called when the Collider other enters the trigger
  void OnTriggerEnter(Collider other) {
    // Destroy(other.gameObject);
    if(other.gameObject.CompareTag("Pick Up")) {
      other.gameObject.SetActive(false);
    }
  }
}
