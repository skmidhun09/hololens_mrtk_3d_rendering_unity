using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MultiFruitRender : MonoBehaviour
{

    private Microsoft.MixedReality.Toolkit.UI.ObjectManipulator objectManipulator;
    static public List<GameObject> hexList;
    public GameObject item1;
    public GameObject item2;
    public GameObject item3;
    public GameObject item4;
    public GameObject item5;



    // Start is called before the first frame update
    void Start()
    {
        hexList = new List<GameObject>();
        hexList.Add(item1);
        hexList.Add(item2);
        hexList.Add(item3);
        hexList.Add(item4);
        hexList.Add(item5);
        for (int i = 0; i < 5; i++)
        {
            hexList[i].SetActive(true);
        }
        StartCoroutine(Text());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Text()  //  <-  its a standalone method
    {
        float pos = -0.4f;
        for (int j = 0; j < 5; j++)
        {
            hexList[j].SetActive(true);
            hexList[j].transform.localScale = new Vector3(200, 200, 200);
            hexList[j].transform.position = new Vector3(pos, 0, 0.5f);
            hexList[j].AddComponent<BoxCollider>();
            hexList[j].AddComponent<Microsoft.MixedReality.Toolkit.Input.NearInteractionGrabbable>();
            hexList[j].AddComponent<Microsoft.MixedReality.Toolkit.UI.ConstraintManager>();
            hexList[j].AddComponent<Microsoft.MixedReality.Toolkit.UI.ObjectManipulator>();
            objectManipulator = hexList[j].GetComponent<Microsoft.MixedReality.Toolkit.UI.ObjectManipulator>();
            objectManipulator.HostTransform = hexList[j].GetComponent<Transform>();
            pos = pos + 0.2f;
        }
        yield return new WaitForSeconds(1);

    }
}
