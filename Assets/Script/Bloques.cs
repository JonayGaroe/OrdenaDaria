using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Bloques : MonoBehaviour
{
    public int bloquesCount = 37;
    public TextMeshProUGUI bloquesText;
    public TextMeshProUGUI bloquesText2;

    public AudioClip Bloquefx;


    // Start is called before the first frame update
    void Start()
    {
        bloquesCount = 37;

    }

    // Update is called once per frame
    void Update()
    {

     

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
         //Asegurarnos de que la colisión es con un objeto con el tag correcto
        //if (other.CompareTag("bloquesss"))

        if (other.gameObject.CompareTag("bloquesss"))
        {
                    // Verificar si el tag coincide antes de hacer el resto de la lógica
                    // Destruir el objeto con el tag "bloquesss"

            bloquesCount = bloquesCount - 1;
            Debug.Log("He tocado el Bloque " + bloquesCount);
            Destroy(other.gameObject);
       

        }


        if (other.gameObject.tag.Contains("bloquesss"))
        {

            Destroy(other.gameObject);
            bloquesText.text = bloquesCount.ToString();
            bloquesText2.text = bloquesCount.ToString();

            

            // bloquesText.text = bloquesCount.ToString();
            // other.gameObject.SetActive(false);
            //  AudioSource.PlayClipAtPoint(Bloquefx, transform.position);

        }




    }
    
}
