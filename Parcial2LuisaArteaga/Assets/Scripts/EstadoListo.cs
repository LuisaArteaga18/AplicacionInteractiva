using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EstadoListo : States
{
    public EstadoListo()
    {
    }

    public override void mensaje(Text texto)
    {
        texto.text = "El huevo está listo, entreguelo al mesero";
    }
}
