using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubirPanelC : MonoBehaviour
{
    [SerializeField] private GameObject Peral;
    public void SubirPanelPeral()

    {
        LeanTween.moveY(Peral.GetComponent<RectTransform>(), 130, 1f);
    }
}
