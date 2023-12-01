using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubirPanelD : MonoBehaviour
{
    [SerializeField] private GameObject Granada;
    public void SubirPanelGranada()

    {
        LeanTween.moveY(Granada.GetComponent<RectTransform>(), 160, 1f);
    }
}
