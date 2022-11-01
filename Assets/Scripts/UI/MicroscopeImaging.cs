using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MicroscopeImaging : MonoBehaviour
{
    [SerializeField] GameObject[] lensImage;
    [SerializeField] GameObject lensImageLit;
    [SerializeField] GameObject microscopePanel;
    [SerializeField] TextMeshProUGUI lensDescription;
    public void DisplayImage(int lensToggle)
    {
        if (lensToggle == -1)
        {
            microscopePanel.SetActive(false);
            lensDescription.text = "";
        }
        else if (lensToggle == 0)
        {
            microscopePanel.SetActive(true);
            lensImage[lensToggle].SetActive(true);
            lensDescription.text = lensImage[lensToggle].name;
        }
        else if (lensToggle > 0)
        {
            try
            {
                microscopePanel.SetActive(true);
                lensImage[lensToggle - 1].SetActive(false);
                lensImage[lensToggle].SetActive(true);
                lensDescription.text = lensImage[lensToggle].name;
            }
            catch (System.Exception)
            {
                lensToggle = 0;
            }
        }
    }

    public void DisplayLitImage()
    {
        microscopePanel.SetActive(true);
        lensImageLit.SetActive(true);
        lensDescription.text = "100X Lens";
    }
}
