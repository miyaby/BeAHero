using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

//		if(Input.touchCount > 0){ // Editor/マウス操作の場合は Input.GetMouseButton(0) にする
		if(Input.GetMouseButton(0)){
			var pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			pos.z = 0;
			transform.position = pos;
		}
	}
}
