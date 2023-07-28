using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TextRender : MonoBehaviour
{
    public GameObject item1;
    public GameObject item2;



    // Start is called before the first frame update
    void Start()
    {
        item1.SetActive(false);
        item2.SetActive(false);
        StartCoroutine(Text());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Text()  //  <-  its a standalone method
    {
        yield return new WaitForSeconds(5);
        item1.SetActive(true);
        item2.SetActive(true);

    }

}
