using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirPorLimites : MonoBehaviour {

    //Al salir de la colisión
	void OnTriggerExit(Collider other){

        //Destruyo el objeto
        Destroy(other.gameObject);

    }
}