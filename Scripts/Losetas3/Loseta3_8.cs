﻿using UnityEngine;
using System.Collections;

public class Loseta3_8 :  Loseta {

	// Use this for initialization
	void Start () {
		numeroApariciones = 3;
		tiposEnLoseta = new tipoLoseta[] {tipoLoseta.CIUDAD,tipoLoseta.CAMINO};
		ladosLoseta = new int[] {0,1,1,0,1};

	}

	// Update is called once per frame
	void Update () {

	}
}
