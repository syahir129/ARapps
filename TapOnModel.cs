using UnityEngine;

public class TapOnModel : MonoBehaviour
{
    public PopupController popupController;
    [TextArea]
    public string popupMessage = "🧼 Grooming Tip:\nBrush the Exotic Shorthair 2–3 times a week to avoid matting.";

    void Update()
    {
        // ✅ Mobile Touch Input
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            TryHit(ray);
        }

        // ✅ Desktop Mouse Input (for Editor testing)
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            TryHit(ray);
        }
    }

    void TryHit(Ray ray)
    {
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log("Tapped on: " + hit.transform.name); // ✅ should print this
            if (hit.transform == transform && popupController != null)
            {
                Debug.Log("PopupController found, showing popup!"); // ✅ add this
                popupController.ShowPopup(popupMessage);
            }
        }
    }
}
