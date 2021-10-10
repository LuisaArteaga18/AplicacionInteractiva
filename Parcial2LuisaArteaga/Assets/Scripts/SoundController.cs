using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    [SerializeField] ChanelSO channel;

    [SerializeField] AudioClip clip;
    private AudioSource sonido;
    // Start is called before the first frame update
    void Start()
    {
        sonido = GetComponent<AudioSource>();
        sonido.clip = clip;
    }

    private void OnEnable()
    {
        channel.listoHuevo += SonidoListo;
    }
    private void OnDisable()
    {
        channel.listoHuevo -= SonidoListo;
    }
    public void SonidoListo()
    {
        sonido.Play();
    }
}

