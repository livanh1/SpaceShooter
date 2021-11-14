using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotadorAleatorio : MonoBehaviour {

    //Para establecer la máxima caída
    public float caida = 5;

	void Start () {

        //Velocidad angular o de rotación = valor alaatorio en una esfera de radio 1 * la caida
        GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * caida;
		
	}
	
}