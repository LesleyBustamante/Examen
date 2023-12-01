using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubirPanelH : MonoBehaviour
{
    [SerializeField] private GameObject Maiz;
    public void SubirPanelMaiz()

    {
        LeanTween.moveY(Maiz.GetComponent<RectTransform>(), 160, 1f);
    }
}
