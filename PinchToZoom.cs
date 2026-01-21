using UnityEngine;

public class PinchToZoom : MonoBehaviour
{
    public float zoomSpeed = 0.01f;
    public float minScale = 0.1f;
    public float maxScale = 2f;

    private Vector2 prevTouch0, prevTouch1;

    void Update()
    {
        if (Input.touchCount == 2)
        {
            // Get both touches
            Touch touch0 = Input.GetTouch(0);
            Touch touch1 = Input.GetTouch(1);

            // Positions in the last frame
            Vector2 touch0PrevPos = touch0.position - touch0.deltaPosition;
            Vector2 touch1PrevPos = touch1.position - touch1.deltaPosition;

            // Distances
            float prevTouchDeltaMag = (touch0PrevPos - touch1PrevPos).magnitude;
            float touchDeltaMag = (touch0.position - touch1.position).magnitude;

            // Difference in distances
            float deltaMagnitudeDiff = touchDeltaMag - prevTouchDeltaMag;

            // Calculate zoom factor
            float scaleFactor = 1 + deltaMagnitudeDiff * zoomSpeed;
            Vector3 newScale = transform.localScale * scaleFactor;

            // Clamp scale
            newScale.x = Mathf.Clamp(newScale.x, minScale, maxScale);
            newScale.y = Mathf.Clamp(newScale.y, minScale, maxScale);
            newScale.z = Mathf.Clamp(newScale.z, minScale, maxScale);

            transform.localScale = newScale;
        }
    }
}
