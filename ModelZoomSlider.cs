using UnityEngine;
using UnityEngine.UI;

public class ModelZoomSlider : MonoBehaviour
{
    public Transform targetModel;     // Assign your 3D model
    public Slider zoomSlider;

    private Vector3 initialScale;

    void Start()
    {
        if (targetModel != null)
        {
            initialScale = targetModel.localScale;
        }

        if (zoomSlider != null)
        {
            zoomSlider.onValueChanged.AddListener(OnZoomChanged);
        }
    }

    void OnZoomChanged(float value)
    {
        if (targetModel != null)
        {
            targetModel.localScale = initialScale * value;
        }
    }
}
