using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonController : MonoBehaviour
{
    [Header("Variables")]
    [SerializeField] private GameObject button;
    [SerializeField] private float activatedHeight;

    [Header("Events")]
    [SerializeField] private UnityEvent ButtonPress;
    [SerializeField] private UnityEvent ButtonUnpressed;
    
    private float deactivatedHeight;

    private void Start()
    {
        deactivatedHeight = button.transform.localPosition.y;
    }

    public void OnActivation() 
    {
        Vector3 newPos = new Vector3(button.transform.localPosition.x,
                                     activatedHeight,
                                     button.transform.localPosition.z);
        button.transform.localPosition = newPos;
        ButtonPress.Invoke();
    }

    public void OnDeactivation() 
    {
        Vector3 newPos = new Vector3(button.transform.localPosition.x,
                                     deactivatedHeight,
                                     button.transform.localPosition.z);
        button.transform.localPosition = newPos;
        ButtonUnpressed.Invoke();
    }
}
