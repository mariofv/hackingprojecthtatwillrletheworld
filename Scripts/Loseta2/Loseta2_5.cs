using UnityEngine;
using System.Collections;

public class Loseta2_5 : Loseta {

	// Use this for initialization
	void Start () {
		numeroApariciones = 1;
		tiposEnLoseta = new tipoLoseta[] {tipoLoseta.CIUDAD,tipoLoseta.CAMPO};
		ladosLoseta = new int[] {0,0,1,0,0};
		escudo = true;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
