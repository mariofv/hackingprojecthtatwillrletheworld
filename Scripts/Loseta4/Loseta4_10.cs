using UnityEngine;
using System.Collections;

public class Loseta4_10 : Loseta {

	// Use this for initialization
	void Start () {
		tiposEnLoseta = new tipoLoseta[] {tipoLoseta.CAMINO,tipoLoseta.CAMPO,tipoLoseta.CIUDAD};
		ladosLoseta = new int[] {0,1,2,1,0};

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}