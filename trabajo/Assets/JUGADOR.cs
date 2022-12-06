using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JUGADOR : MonoBehaviour
{
    public float velocidad;
    public float velRotacion;
    public CharacterController controller;
    private bool delante;
    private bool atras;
    private bool derecha;
    private bool izquierda;
    private bool Rderecha;
    private bool Rizquierda;

   
    // Update is called once per frame
    void Update()
    {
        if(delante==true)
        {
            controller.Move(transform.forward * velocidad * Time.deltaTime);
        }
        if(atras==true)
        {
            controller.Move(-transform.forward * velocidad * Time.deltaTime);
        }
        if(derecha==true)
        {
            controller.Move(transform.right * velocidad * Time.deltaTime);
        }
        if(izquierda==true)
        {
            controller.Move(-transform.right * velocidad * Time.deltaTime);
        }
        if(Rderecha==true)
        {
            transform.Rotate(-Vector3.up * velRotacion * Time.deltaTime);
        }
        if(Rizquierda==true)
        {
            transform.Rotate(Vector3.up * velRotacion * Time.deltaTime);
        }
    }

    public void MoverAdelante()
    {
        delante = true;
    }
    public void MoverAtras()
    {
        atras = true;
    }
    public void MoverIzquierda()
    {
        izquierda = true;
    }
    public void MoverDerecha()
    {
        derecha = true;
    }
    public void RotarDerecha()
    {
        Rderecha = true;
    }
    public void RotarIzquierda()
    {
        Rizquierda = true;
    }
    public void Nfuncion()
    {
        delante = false;
        atras = false;
        derecha = false;
        izquierda = false;
        Rderecha = false;
        Rizquierda = false;
    }
   
}
