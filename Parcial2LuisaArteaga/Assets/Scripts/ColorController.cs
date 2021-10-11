using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorController : MonoBehaviour
{
    [SerializeField] ChanelSO channelEvents;
    [SerializeField] Slider slider;

    [SerializeField] Renderer huevoColor;
    ColorCreator colorGenerator = new ColorCreator();

    public Text textico;
    StateMachine stateMachine = new StateMachine();
    //States estados = new EstadoListo();

    public void Awake()
    {

    }

    public void OnEnable()
    {
        channelEvents.cocinado += CambiaColorHuevo;
    }
    public void OnDisable()
    {
        channelEvents.cocinado -= CambiaColorHuevo;
    }

    public void CambiaColorHuevo()
    {
        if (slider.value < 1 / 4) stateMachine.HuevoCrudo(textico);

        if (slider.value >= 1 / 2)
        {
            colorGenerator.huevoCrudo(huevoColor);
            stateMachine.huevoCocinando(textico);
        }
        if (slider.value > 0.8f)
        {
            colorGenerator.HuevoListo(huevoColor);
            stateMachine.HuevoListo(textico);
        }
    }
}
