using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubirPanelB : MonoBehaviour
{
    [SerializeField] private GameObject Cerezo;
    public void SubirPanelCerezo()

    {
        LeanTween.moveY(Cerezo.GetComponent<RectTransform>(), 100, 1f);
    }
}
