using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color2 : InterfaceColor
{
    public void AsignarColor(Renderer material)
    {
        material.material.color = Color.white;
    }
}
