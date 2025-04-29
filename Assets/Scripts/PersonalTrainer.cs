using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonalTrainer : MonoBehaviour
{
    public string tipoEntrenamineto;
    public float horasReservadas;
    float cardioV = 1000;
    float fuerzaV = 1500;
    float recreativoV = 2500;
    float valorTotal;
    float valorDescuento;

    // Start is called before the first frame update
    void Start()
    {
        if (tipoEntrenamineto != "Cardio" && tipoEntrenamineto != "Fuerza" && tipoEntrenamineto != "Recreativo")
        {
            Debug.Log("El servicio elegido no está disponible");
            return;
        } else if (horasReservadas < 1 || horasReservadas > 6)
        {
            Debug.Log("cantidad de horas no validas. Solo se pueden de 1 a 6");
            return;
        }
        else if (tipoEntrenamineto == "Cardio")
        {
            valorTotal = cardioV * horasReservadas;

        }
        else if (tipoEntrenamineto == "Fuerza" && horasReservadas > 6)
        {
            valorTotal = fuerzaV * horasReservadas;
        }
        else
        {
            valorTotal = recreativoV * horasReservadas;
        }
        if (horasReservadas < 6)
        {
            Debug.Log(".Tipo de entrenamiento " + tipoEntrenamineto);
            Debug.Log(".Horas reservadas " + horasReservadas);
            Debug.Log(".Precio sin descuento " + valorTotal);
        } else
        {
         valorDescuento = valorTotal * 9 / 10;
            Debug.Log(".Tipo de entrenamiento " + tipoEntrenamineto);
            Debug.Log(".Horas reservadas " + horasReservadas);
            Debug.Log(".Precio sin descuento " + valorTotal);
            Debug.Log(".Precio con descuento " + valorDescuento);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

    

