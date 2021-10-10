using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoccionController : MonoBehaviour
{
    [SerializeField] ChanelSO channelEvents;
    [SerializeField] Slider slider;
    public float valor;

    public void OnEnable()
    {
        channelEvents.cocinado += ValorSlider;
    }
    public void OnDisable()
    {
        channelEvents.cocinado -= ValorSlider;
    }

    public void ValorSlider()
    {
        slider.value += valor;
    }
}
