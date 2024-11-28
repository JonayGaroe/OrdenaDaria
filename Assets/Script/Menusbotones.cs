    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Threading;
public class Menusbotones : MonoBehaviour
{
    [SerializeField]
    GameObject startNivel;
    [SerializeField]
    GameObject nivel1;
    [SerializeField]
    GameObject nivel2;

    [SerializeField]
    GameObject atras;

    [SerializeField]
    GameObject antesNiveles;

    [SerializeField]
    GameObject despuesNiveles;

    [SerializeField] 
    GameObject menuPrincipal;

    [SerializeField]
    GameObject botonControles;
  //  [SerializeField]
   // GameObject canvasModos;
    [SerializeField]
    GameObject Bolaaa;
    [SerializeField]
    GameObject timesss;

    // Start is called before the first frame update
    void Start()
    {
        






    }

    // Update is called once per frame
    void Update()
    {
        



    }
    public void startniveles()
    {

        menuPrincipal.SetActive(false);
       // canvasModos.SetActive(true);
        Bolaaa.SetActive(true);
        timesss.SetActive(true);

    }
    public void MenuPrincipal()
    {
        menuPrincipal.SetActive(true);
        antesNiveles.SetActive(false);
        botonControles.SetActive(false);
        Bolaaa.SetActive(false);
    }

    public void nivelear()
    {

        antesNiveles.SetActive(true);
        menuPrincipal.SetActive(false);





    }
    public void Ayuda()
    {


        botonControles.SetActive(true);





    }

    public void quitarMenu()
    {
        menuPrincipal.SetActive(false);
      

    }






}
