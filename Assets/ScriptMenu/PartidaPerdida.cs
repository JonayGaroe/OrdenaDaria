using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class PartidaPerdida : MonoBehaviour
{

    public int vidas = 3;
    public TextMeshProUGUI  vidasText; // Referencia al texto de la UI que mostrará las vidas (opcional)

    [SerializeField]
    GameObject pantallaFinal;

    [SerializeField]
    TextMeshProUGUI textLabelTime;

    [SerializeField]
    TextMeshProUGUI textLTime;
    [SerializeField]
    TextMeshProUGUI ganar;
      [SerializeField]
    GameObject ganarla;
    float tiempoDePartida = 0.0f;
    bool estaJugando = true;




    private void Update()
    {
        vidasText.text ="" + vidas;
    
        if (estaJugando == true)
        {

            tiempoDePartida = tiempoDePartida + Time.deltaTime;
            textLabelTime.text = tiempoDePartida.ToString();
            estaJugando = false;
            // ganar.text = tiempoDePartida.ToString();



            

        }
  
        




    }


    private void OnTriggerEnter2D(Collider2D other)

    {

        if (other.tag == "Player")
        {

            vidas--;

            if (vidas <= 0)
            {
                Time.timeScale = 0;
              float minutos = Mathf.FloorToInt(tiempoDePartida / 60F);
              float segundos = Mathf.FloorToInt(tiempoDePartida % 60F);


              Debug.Log("Has Perdido");
              pantallaFinal.SetActive(true);
              other.GetComponent<Movimiento>().enabled = false;
              estaJugando = false;
              textLabelTime.text = string.Format("{0:00}:{1:00}", minutos, segundos);
           


            }


            /*
            float minutos = Mathf.FloorToInt(tiempoDePartida / 60F);
            float segundos = Mathf.FloorToInt(tiempoDePartida % 60F);


            Debug.Log("Jugador llego a la meta");
            pantallaFinal.SetActive(true);
            other.GetComponent<Movimiento>().enabled = false;
            estaJugando = false;
            textLabelTime.text = string.Format("{0:00}:{1:00}", minutos, segundos);
            */

        }

    }





}
