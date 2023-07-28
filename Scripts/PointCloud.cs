using UnityEngine;
using System.IO;

public class PointCloud : MonoBehaviour
{
    public GameObject pointPrefab;
    public string csvFilePath;

    void Start()
    {
        using (var reader = new StreamReader(csvFilePath))
        {
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');

                float x = float.Parse(values[0]);
                float y = float.Parse(values[1]);
                float z = float.Parse(values[2]);

                float r = float.Parse(values[3]);
                float g = float.Parse(values[4]);
                float b = float.Parse(values[5]);

                Vector3 position = new Vector3(x, y, z);
                Color color = new Color(r, g, b);

                GameObject point = Instantiate(pointPrefab, position, Quaternion.identity, transform);
                point.GetComponent<Renderer>().material.color = color;
            }
        }
    }
}