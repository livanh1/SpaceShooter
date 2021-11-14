using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirPorTiempo : MonoBehaviour {

    public float tiempoDeVida;

    void Start () {

        //destruyo el objeto después de un tiempo de vida
        Destroy(gameObject, tiempoDeVida);

    }
	
}