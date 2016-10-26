using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Puntaje : MonoBehaviour {

    public float puntajeGanado = 0f;
    public Text textoDePuntaje;
	// Use this for initialization
	void Start () {
        puntajeGanado = 0f;
	}
	
	// Update is called once per frame
	void Update () {
        puntajeGanado = puntajeGanado + 1;
        //puntajeGanado = puntajeGanado + Time.deltaTime * 100;
        Escribir();
    }
    void Escribir()
    {
        //puntajeGanado = (int)puntajeGanado;
        textoDePuntaje.text = "COINS: " + puntajeGanado;
    }
}
