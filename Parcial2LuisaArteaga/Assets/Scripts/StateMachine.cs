using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StateMachine : MonoBehaviour
{
    public States estados;
    public StateMachine()
    {

    }

    public void HuevoListo(Text texto)
    {
        estados = new EstadoListo();
        estados.mensaje(texto);
    }

    public void HuevoCrudo(Text texto)
    {
        estados = new Estado_crudo();
        estados.mensaje(texto);
    }

    public void huevoCocinando(Text texto)
    {
        estados = new EstadoCocinado();
        estados.mensaje(texto);
    }
}
