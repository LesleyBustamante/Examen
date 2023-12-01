using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bajada_Arbusto : MonoBehaviour
{
    [SerializeField] private GameObject Arbusto;
    public void SubirArbusto()

    {
        LeanTween.moveY(Arbusto.GetComponent<RectTransform>(), 35, 1f);
    }
}
