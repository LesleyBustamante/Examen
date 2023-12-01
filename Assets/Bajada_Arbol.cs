using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bajada_Arbol : MonoBehaviour
{
    [SerializeField] private GameObject Arbol;
        public void SubirArbolito()

    {
        LeanTween.moveY(Arbol.GetComponent<RectTransform>(), 35, 1f);
    }
}
