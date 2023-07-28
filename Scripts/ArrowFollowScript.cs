using System.Collections;
using UnityEngine;

public class ArrowFollowScript : MonoBehaviour
{
    public float offsetX = 0.06f; // The value to add to the X axis
    public GameObject fruit;
    public GameObject arrow;
    public GameObject text;
    public GameObject highlight_mesh;
    private float x_angle;
    private float y_angle;
    private float max_deviation = 45.0f;
    void Start()
    {
        StartCoroutine(Text());
    }
    IEnumerator Text()  //  <-  its a standalone method
    {
        yield return new WaitForSeconds(2);
        x_angle = Mathf.Abs(fruit.transform.eulerAngles.x);
        y_angle = Mathf.Abs(fruit.transform.eulerAngles.y);


    }
    void Update()
    {
        
        // Get the current position of the object
        Vector3 currentPosition = fruit.transform.position;
        currentPosition.z = currentPosition.z - 0.05f;
        print(fruit.transform.eulerAngles.x);

        if (x_angle + max_deviation < Mathf.Abs(fruit.transform.eulerAngles.x) || x_angle - max_deviation > Mathf.Abs(fruit.transform.eulerAngles.x) || y_angle + max_deviation < Mathf.Abs(fruit.transform.eulerAngles.y) || y_angle - max_deviation > Mathf.Abs(fruit.transform.eulerAngles.y))
        {
            arrow.SetActive(false);
            text.SetActive(false);
            highlight_mesh.SetActive(false);

        }
        else
        {
            arrow.SetActive(true);
            text.SetActive(true);
            highlight_mesh.SetActive(true);
        }

        //currentPosition += scaledTranslation;
        arrow.transform.position = currentPosition;

    }
    
}

