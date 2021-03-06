﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMyself : MonoBehaviour {
	//Unityちゃんのオブジェクト
	private GameObject unitychan;
	//Unityちゃんとアイテムの距離
	private float difference;

	// Use this for initialization
	void Start () {
		//Unityちゃんのオブジェクトを取得
		this.unitychan = GameObject.Find ("unitychan");
	}
	
	// Update is called once per frame
	void Update () {
		//Unityちゃんとアイテムの位置（z座標）の差を求める
		this.difference = unitychan.transform.position.z - this.transform.position.z;
		if (this.difference > 8) {
			Destroy (this.gameObject);
		}
	}
}
