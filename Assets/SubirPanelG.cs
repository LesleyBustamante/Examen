using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubirPanelG : MonoBehaviour
{
    [SerializeField] private GameObject Papa;
    public void SubirPanelPapa()

    {
        LeanTween.moveY(Papa.GetComponent<RectTransform>(), 115, 1f);
    }
}
