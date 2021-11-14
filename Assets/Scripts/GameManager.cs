using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public GameObject[] asteroides; //objeto a instanciar
    public Vector3 posicion; //posición (límites) en la que instanciar
    public int numeroDeAsteroides; //número de objetos en cada ola
    public float esperaInicial;
    public float esperaEntreAsteroides;
    public float esperaEntreOlas;
    public Text textoContador; //caja de texto para el contador
    public int contador; //Entero para contar los puntos
    public Text textoMensajes; //caja de texto para el mensaje de juego terminado

    void Start () {

        StartCoroutine(crearAsteroides());

        //Inicializo el contador
        textoContador.text = "Puntuación: 0";

        //Oculto el mensaje de juego terminado
        textoMensajes.enabled = false;

    }

    IEnumerator crearAsteroides(){

        //Espera inicial
        yield return new WaitForSeconds(esperaInicial);

        while (true){

            for (int i = 0; i < numeroDeAsteroides; i++)
            {
                GameObject asteroide = asteroides[Random.Range(0, asteroides.Length)];
                //Posición aleatoria entre los límites (positivo y negativo) que establezcamos
                Vector3 posicionAsteroide = new Vector3(Random.Range(-posicion.x, posicion.x), posicion.y, posicion.z);
                //Rotación
                Quaternion rotacionAsteroide = Quaternion.identity;
                //Instancio el asteroide
                Instantiate(asteroide, posicionAsteroide, rotacionAsteroide);
                //Espera entre asteroides
                yield return new WaitForSeconds(esperaEntreAsteroides);
            }

            //Espera entre olas
            yield return new WaitForSeconds(esperaEntreOlas);

        }
           
    }

    //Actualizo el contador (desde DestruirPorContacto)
    public void actualizarContador(){

        contador += 10;
        textoContador.text = "Puntuación: " + contador;

    }

    void Update()
    {
        //Reiniciar el juego con la tecla R
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Juego");
        }
    }
}