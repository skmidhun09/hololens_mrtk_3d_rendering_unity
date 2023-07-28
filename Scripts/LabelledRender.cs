using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LabelledRender : MonoBehaviour
{

    private Microsoft.MixedReality.Toolkit.UI.ObjectManipulator objectManipulator;
    public GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Text());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Text()  //  <-  its a standalone method
    {
        //yield return new WaitForSeconds(5);
            obj.SetActive(true);
            obj.transform.localScale = new Vector3(200, 200, 200);
            obj.transform.position = new Vector3(0, 0, 0.5f);
            obj.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            obj.AddComponent<BoxCollider>();
            obj.AddComponent<Microsoft.MixedReality.Toolkit.Input.NearInteractionGrabbable>();
            obj.AddComponent<Microsoft.MixedReality.Toolkit.UI.ConstraintManager>();
            obj.AddComponent<Microsoft.MixedReality.Toolkit.UI.ObjectManipulator>();
            objectManipulator = obj.GetComponent<Microsoft.MixedReality.Toolkit.UI.ObjectManipulator>();
            objectManipulator.HostTransform = obj.GetComponent<Transform>();
        yield return new WaitForSeconds(5);
        // Get the MeshFilter component
  /*      MeshFilter meshFilter = obj.GetComponent<MeshFilter>();

        // Access the mesh
        Mesh mesh = meshFilter.mesh;

        // Check if vertex colors are available
        if (mesh.colors.Length == 0)
        {
            Debug.LogWarning("Vertex colors are not available in the mesh.");
        }

        // Retrieve the vertex colors
        Color[] vertexColors = mesh.colors;

        // Get the number of vertices
        int vertexCount = mesh.vertexCount;

        // Determine the index to start coloring
        int startIndex = 0;
        int endIndex = vertexCount / 2; // Change this line to adjust the portion of the mesh to color

        // Color the specified portion of the vertices
        for (int i = startIndex; i < endIndex; i++)
        {
            vertexColors[i] = Color.red;
        }

        // Assign the modified vertex colors back to the mesh
        mesh.colors = vertexColors;*/
    }
}
