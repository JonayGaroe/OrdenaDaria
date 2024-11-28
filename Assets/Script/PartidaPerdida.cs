using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class PartidaPerdida : MonoBehaviour
{

    [SerializeField]
    GameObject pantallaFinal;

    [SerializeField]
    TextMeshProUGUI textLabelTime;


    float tiempoDePartida = 0.0f;
    bool estaJugando = true;




    private void Update()
    {

        if (estaJugando == true)
        {
            tiempoDePartida = tiempoDePartida + Time.deltaTime;
            textLabelTime.text = tiempoDePartida.ToString();

        }
    }

    private void OnTriggerEnter2D(Collider2D other)

    {

        if (other.tag == "Player")

        {
            float minutos = Mathf.FloorToInt(tiempoDePartida / 60F);
            float segundos = Mathf.FloorToInt(tiempoDePartida % 60F);


            Debug.Log("Jugador llego a la meta");
            pantallaFinal.SetActive(true);
            other.GetComponent<Movimiento>().enabled = false;
            estaJugando = false;
            textLabelTime.text = string.Format("{0:00}:{1:00}", minutos, segundos);


        }

    }





}
