
using UnityEngine;

public class LabelFollowScript : MonoBehaviour
{
    public float offsetX = 0.06f; // The value to add to the X axis
    public GameObject fruit;
    void Update()
    {
        
        // Get the current position of the object
        Vector3 currentPosition = fruit.transform.position;

        // Add the offset value to the X axis
        //currentPosition.y += offsetX;
        /*Vector3 scaledTranslation = Vector3.up;
        scaledTranslation.Scale(transform.localScale);*/

        // scaledTranslation.y = scaledTranslation.y + offsetX;
        // Add the scaled translation amount to the current position
        currentPosition.y = currentPosition.y + 0.05f;
        currentPosition.x = currentPosition.x + 0.07f;
        currentPosition.z = currentPosition.z - 0.05f;
        //currentPosition += scaledTranslation;

        // Translate the object to the new position
        transform.position = currentPosition;
    }
}

