using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EstadoCocinado : States
{
    public EstadoCocinado()
    {
    }


    public override void mensaje(Text texto)
    {
        texto.text = "Se esta cocinando el huevo";
    }

}
