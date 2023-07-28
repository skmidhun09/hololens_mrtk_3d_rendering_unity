using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FruitRender : MonoBehaviour
{

    private Microsoft.MixedReality.Toolkit.UI.ObjectManipulator objectManipulator;
    static public List<GameObject> hexList;
    public GameObject item1;
    public GameObject item2;
    public GameObject item3;
    public GameObject item4;
    public GameObject item5;
    public GameObject item6;
    public GameObject item7;
    public GameObject item8;
    public GameObject item9;
    public GameObject item10;


    // Start is called before the first frame update
    void Start()
    {
        hexList = new List<GameObject>();
        hexList.Add(item1);
        hexList.Add(item2);
        hexList.Add(item3);
        hexList.Add(item4);
        hexList.Add(item5);
        hexList.Add(item6);
        hexList.Add(item7);
        hexList.Add(item8);
        hexList.Add(item9);
        hexList.Add(item10);
        for (int i = 0; i < 10; i++)
        {
            hexList[i].SetActive(false);
        }
        StartCoroutine(Text());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Text()  //  <-  its a standalone method
    {
        for (int j = 0; j < 10; j++)
        {
            hexList[j].SetActive(true);
            hexList[j].transform.localScale = new Vector3(200, 200, 200);
            hexList[j].transform.position = new Vector3(0, 0, 0.5f);
            hexList[j].AddComponent<BoxCollider>();
            hexList[j].AddComponent<Microsoft.MixedReality.Toolkit.Input.NearInteractionGrabbable>();
            hexList[j].AddComponent<Microsoft.MixedReality.Toolkit.UI.ConstraintManager>();
            hexList[j].AddComponent<Microsoft.MixedReality.Toolkit.UI.ObjectManipulator>();
            objectManipulator = hexList[j].GetComponent<Microsoft.MixedReality.Toolkit.UI.ObjectManipulator>();
            objectManipulator.HostTransform = hexList[j].GetComponent<Transform>();
            yield return new WaitForSeconds(20);
            hexList[j].SetActive(false);
        }

    }
}
