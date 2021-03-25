using System.Collections;
using TMPro;
using UnityEngine;
using Vuforia;

public class vb_anim : MonoBehaviour
{
    public GameObject   buttonObject;
    public Animation    wavingAnimation;
    public MeshRenderer plane;
    public Animation bubbleAnimation;
    
    private Color _pressedOrHoldColor = new Color(0.882f, 0.176f, 0.313f, 0.754f);
    private Color _releasedColor      = new Color(0.176f, 0.882f, 0.823f, 0.754f);
    
    void Start()
    {
        buttonObject = GameObject.Find("KyleButton");
        buttonObject.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        buttonObject.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonReleased);

        wavingAnimation.GetComponent<Animation>();
        bubbleAnimation.GetComponent<Animation>();

        plane.GetComponent<MeshRenderer>();
    }

    void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        plane.material.color = _pressedOrHoldColor;
        wavingAnimation.Play();
        bubbleAnimation.Play();
    }

    void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        plane.material.color = _releasedColor;
    }
}
