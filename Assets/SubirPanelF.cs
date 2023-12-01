using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubirPanelF : MonoBehaviour
{
    [SerializeField] private GameObject Fresas;
    public void SubirPanelFresas()

    {
        LeanTween.moveY(Fresas.GetComponent<RectTransform>(), 100, 1f);
    }
}
