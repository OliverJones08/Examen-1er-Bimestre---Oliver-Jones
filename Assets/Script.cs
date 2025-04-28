using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    public string TipoDeEntrada;
    public int CantDeEntrada;
    public bool Prioridad;


    string Basico; 
    string Normal;
    string Premium;
    int precioTotal;
    int EntradaBasica = 800;
    int EntradaNormal = 12000;
    int EntradaPremium = 2000;
    float Descuento = 15;
    float Descuento3 = 10;
    float PrecioRecargo;

    // Start is called before the first frame update
    void Start()
    {
        if (TipoDeEntrada == "n" || TipoDeEntrada == "b" || TipoDeEntrada == "p")
        {
            Debug.Log("Tipo de entrada valido");
        }
            
        else
        {
            Debug.Log("Tipo de entrada no valida");
        }


            
        if (CantDeEntrada > 1)
        {
            Debug.Log("Cantidad de entradas no valida");
        }
     
        else if (CantDeEntrada <= 1)
        {
            Debug.Log("Cantidad de entradas valida");
        }



        if (TipoDeEntrada == "p" && Prioridad == true)
        {
            PrecioRecargo = EntradaPremium * (Descuento / 100);
            Debug.Log("Usted tiene prioridad en la fila, su recargo es de $" +PrecioRecargo);
        }
            
        else if (TipoDeEntrada == "b" || TipoDeEntrada == "n" || Prioridad == false)
        {
            Debug.Log("Usted no tiene acceso a poder comprar prioridad en la fila");
        }



        if (TipoDeEntrada == "b" && CantDeEntrada >= 4)
        {
            precioTotal = EntradaBasica * CantDeEntrada;
        }
        else
        {
            Debug.Log("La cantidad de entradas supera el limite");
        }


        if (TipoDeEntrada == "n" && CantDeEntrada >= 6)
        {
            precioTotal = EntradaNormal * CantDeEntrada;
        }
        else
        {
            Debug.Log("La cantidad de entradas supera el limite");
        }

        if (TipoDeEntrada == "p")
        {
            precioTotal = EntradaPremium * CantDeEntrada;
        }

        if (CantDeEntrada > 3 || TipoDeEntrada == "p")
        {

        }

        Debug.Log("Tipo de entrada:" + TipoDeEntrada + "- cantidad: " + CantDeEntrada + "- precio total:$" +precioTotal);
            


        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
