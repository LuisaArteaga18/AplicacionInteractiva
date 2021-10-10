using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Estado_crudo : States
{
    public Estado_crudo()
    {
    }

    public override void mensaje(Text texto)
    {
        texto.text = "El huevo esta crudo, cocine el huevo con el boton";
    }
}

