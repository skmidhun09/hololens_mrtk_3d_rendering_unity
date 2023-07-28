using UnityEngine;

public class HighlightCircularPattern : MonoBehaviour
{
    public Material highlightMaterial; // Material for highlighting
    public float highlightRadius = 1.0f; // Highlight radius

    private Material originalMaterial; // Original material of the object
    private Renderer objectRenderer; // Renderer component of the object

    private void Start()
    {
        // Get the Renderer component of the object
        objectRenderer = GetComponent<Renderer>();

        // Store the original material of the object
        originalMaterial = objectRenderer.material;
    }

    private void Update()
    {
        // Cast a ray from the camera to the mouse position
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        // Check if the ray hits the object
        if (Physics.Raycast(ray, out hit))
        {
            // Check if the hit object is the same as this object
            if (hit.collider.gameObject == gameObject)
            {
                // Get the hit point on the object's surface
                Vector3 hitPoint = hit.point;
                hitPoint = transform.InverseTransformPoint(hitPoint);

                // Calculate the distance of the hit point from the object's center
                float distance = Vector3.Distance(Vector3.zero, hitPoint);

                // Check if the distance is within the highlight radius
                if (distance <= highlightRadius)
                {
                    // Set the object's material to the highlight material
                    objectRenderer.material = highlightMaterial;
                }
                else
                {
                    // Revert back to the original material of the object
                    objectRenderer.material = originalMaterial;
                }
            }
            else
            {
                // Revert back to the original material of the object
                objectRenderer.material = originalMaterial;
            }
        }
        else
        {
            // Revert back to the original material of the object
            objectRenderer.material = originalMaterial;
        }
    }
}
