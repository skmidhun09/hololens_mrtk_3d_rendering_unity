using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshTranslation : MonoBehaviour
{
    public GameObject apple;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = apple.transform.position;
    }
}
