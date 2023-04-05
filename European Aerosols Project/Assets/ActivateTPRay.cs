using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ActivateTPRay : MonoBehaviour
{
    public GameObject rightTP;

    public InputActionProperty rightActivate;

    private void Update()
    {
        rightTP.SetActive(rightActivate.action.ReadValue<float>() > 0.1f);
    }
}
