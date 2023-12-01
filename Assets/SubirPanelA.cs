using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubirPanelA : MonoBehaviour
{
    [SerializeField] private GameObject Limon;
    public void SubirPanelLimon()

    {
        LeanTween.moveY(Limon.GetComponent<RectTransform>(), 70, 1f);
    }
}
