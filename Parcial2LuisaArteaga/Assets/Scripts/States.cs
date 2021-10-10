using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class States : MonoBehaviour
{
    public Text texto;
    public States()
    {

    }

    virtual public void mensaje(Text texto)
    {

    }
}
