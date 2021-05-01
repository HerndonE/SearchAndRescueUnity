/*
Ethan Herndon
Capstone CST 499; Search and Rescue AR prototype
Spring 2021
Description: This program rotates an object on first frame
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate: MonoBehaviour {
  // Start is called before the first frame update
  void Start() {
    transform.Rotate(-90, 0, 0);
  }

  // Update is called once per frame
  void Update() {

  }
}