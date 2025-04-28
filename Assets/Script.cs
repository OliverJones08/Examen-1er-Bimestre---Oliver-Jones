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
    int precio;
    int EntradaBasica = 800;
    int EntradaNormal = 12000;
    int EntradaPremium = 2000;

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
            Debug.Log("Usted tiene prioridad en la fila");
        }
            
        else if (TipoDeEntrada == "b" || TipoDeEntrada == "n" || Prioridad == false)
        {
            Debug.Log("Usted no tiene acceso a poder comprar prioridad en la fila");
        }

        if (TipoDeEntrada == "b")
        {
            precio = EntradaBasica;
        }


            

        Debug.Log("Tipo de entrada:" + TipoDeEntrada + "- cantidad: " + CantDeEntrada + "- precio total:" + precio)
            


        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}



// Variables declaration
public string flavourCode;
public int iceCreamAmount;

float priceByKG = 500;
float totalPrice;
float discountAmount;
float totalPriceWithDiscount;


// Start is called before the first frame update
void Start()
{
    // Insert and data validation
    if (iceCreamAmount < 250 || iceCreamAmount > 3000)
    {
        Debug.Log("Cantidad de helado no valida");
        return;
    }
    if (flavourCode == "CHO" || flavourCode == "DDL" || flavourCode == "FRU")
    {
        discountAmount = 0;
    }
    else if (flavourCode == "FRU")
    {
        discountAmount = 10;
    }
    else
    {
        Debug.Log("Codigo de gusto no valido");
        return;
    }


    // data prosscesing

    totalPrice = iceCreamAmount * (priceByKG / 1000);
    totalPriceWithDiscount = totalPrice * (discountAmount / 100);

}