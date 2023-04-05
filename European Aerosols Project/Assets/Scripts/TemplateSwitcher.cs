using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TemplateSwitcher : MonoBehaviour
{
    [SerializeField] GameObject template1;
    [SerializeField] GameObject template2;
    [SerializeField] GameObject template3;

    public void ToggleTemplateOne()
    {
        template1.SetActive(true);
        template2.SetActive(false);
        template3.SetActive(false);
    }

    public void ToggleTemplateTwo()
    {
        template1.SetActive(false);
        template2.SetActive(true);
        template3.SetActive(false);
    }

    public void ToggleTemplateThree()
    {
        template1.SetActive(false);
        template2.SetActive(false);
        template3.SetActive(true);
    }
}
