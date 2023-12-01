using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubirPanelE : MonoBehaviour
{
    [SerializeField] private GameObject Trigo;
    public void SubirPanelTrigo()

    {
        LeanTween.moveY(Trigo.GetComponent<RectTransform>(), 55, 1f);
    }
}
