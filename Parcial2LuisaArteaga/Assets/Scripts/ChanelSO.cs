using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class ChanelSO : ScriptableObject
{
    //patron observer
    public delegate void Cocinado();
    public event Cocinado cocinado;

    public delegate void ListoHuevo();
    public event ListoHuevo listoHuevo;

    public void Cocinando_()
    {
        cocinado?.Invoke();
    }

    public void Listo_Huevo()
    {
        listoHuevo?.Invoke();
    }
}
