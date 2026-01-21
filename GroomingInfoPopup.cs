using UnityEngine;
using TMPro;

public class GroomingInfoPopup : MonoBehaviour
{
    [Header("UI References")]
    public GameObject popupPanel;
    public TextMeshProUGUI popupText;

    [Header("Grooming Message")]
    [TextArea]
    public string groomingMessage = "Brush the Exotic Shorthair’s coat twice a week to remove loose fur and reduce shedding.";

    // Call this when info button is clicked
    public void ShowGroomingInfo()
    {
        if (popupPanel != null && popupText != null)
        {
            popupText.text = groomingMessage;
            popupPanel.SetActive(true);
        }
    }

    // Call this when close button is clicked
    public void HideGroomingInfo()
    {
        if (popupPanel != null)
        {
            popupPanel.SetActive(false);
        }
    }
}
