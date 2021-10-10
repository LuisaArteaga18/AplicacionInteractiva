using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCreator : MonoBehaviour
{
    InterfaceColor colorHuevo;
    public void HuevoListo(Renderer material)
    {
        colorHuevo = new Color2();
        colorHuevo.AsignarColor(material);
    }

    public void huevoCrudo(Renderer material)
    {
        colorHuevo = new Color1();
        colorHuevo.AsignarColor(material);
    }
}
