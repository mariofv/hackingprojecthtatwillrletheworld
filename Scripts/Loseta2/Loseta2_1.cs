using UnityEngine;
using System.Collections;

public class Loseta2_1 : Loseta {

	// Use this for initialization
	void Start () {
		numeroApariciones = 1;
		tiposEnLoseta = new tipoLoseta[] {tipoLoseta.CIUDAD};
		ladosLoseta = new int[] {0,0,0,0,0};
		escudo = true;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
