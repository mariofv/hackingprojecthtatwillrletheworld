﻿using UnityEngine;
using System.Collections;

public class Loseta1_1 : Loseta {

	// Use this for initialization
	void Start () {
		tiposEnLoseta = new tipoLoseta[] {tipoLoseta.CAMINO,tipoLoseta.MONASTERIO,tipoLoseta.CAMPO};
		ladosLoseta = new int[] { 3, 3, 1, 3, 2 };

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}