using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SustainAlpha : MonoBehaviour
{
    public MeshRenderer bubble;
    public TextMeshPro  thisText;
    void Start()
    {
        bubble.GetComponent<MeshRenderer>();
        thisText.GetComponent<TextMeshPro>();
    }

    void Update()
    {
        thisText.color = new Color(thisText.color.r, thisText.color.g, thisText.color.b, bubble.material.color.a);
    }
}
