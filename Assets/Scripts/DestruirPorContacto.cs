using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirPorContacto : MonoBehaviour
{

    public GameObject explosion;
    public GameObject explosionNave;
    GameManager gameManager;


    void Start()
    {
        //Busco el script de GameManager
        gameManager = FindObjectOfType<GameManager>();
    }

    //Al entrar en el objeto
    void OnTriggerEnter(Collider other)
    {
        //Para que no se destruya con los límites
        if (other.name != "Limites")
        {
           


            //Explosión del disparo en su posición y rotación
            Instantiate(explosion, transform.position, transform.rotation);

            if (other.name == "Nave")
            {
                //Explosión de la nave en su posición y rotación
                Instantiate(explosionNave, other.transform.position, other.transform.rotation);

                //Mostrar mensaje de juego terminado
                gameManager.textoMensajes.enabled = true;

            }

            //Destruyo el disparo (con el que ha chocado)
            Destroy(other.gameObject);

            //Destruyo el asteroide
            Destroy(gameObject);

            //Actualizo el contador
            gameManager.actualizarContador();
        }
    }
}
