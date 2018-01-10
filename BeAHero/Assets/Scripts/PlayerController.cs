using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

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
//			transform.position = pos;//瞬間移動

			//1秒で移動
//			transform.DOMove (
//				pos,//移動後の座標
//				1.0f //時間
//			);

			//一定の速度で移動
			float dict = Vector3.Distance(pos,transform.position);
			float rate = 2.0f;
			transform.DOMove (
				pos,//移動後の座標
				dict/rate //時間
			);
		}
	}
}
