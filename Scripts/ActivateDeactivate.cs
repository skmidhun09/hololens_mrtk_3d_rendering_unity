using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateDeactivate : MonoBehaviour
{
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
    public GameObject item11;
    public GameObject item12;
    public GameObject item13;
    public GameObject item14;
    public GameObject item15;
    public GameObject item16;
    public GameObject item17;
    public GameObject item18;
    public GameObject item19;
    public GameObject item20;
    public GameObject item21;
    public GameObject item22;
    public int currentItem = 0;



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
        hexList.Add(item11);
        hexList.Add(item12);
        hexList.Add(item13);
        hexList.Add(item14);
        hexList.Add(item15);
        hexList.Add(item16);
        hexList.Add(item17);
        hexList.Add(item18);
        hexList.Add(item19);
        hexList.Add(item20);
        hexList.Add(item21);
        hexList.Add(item22);
        for (int i = 0; i < 22; i++)
        {
            hexList[i].SetActive(false);
        }
        StartCoroutine(Text());

    }

    // Update is called once per frame
    void Update()
    {
        hexList[currentItem].transform.Rotate(Vector3.up * 50.0f * Time.deltaTime);
    }


    IEnumerator Text()  //  <-  its a standalone method
    {
        for (int j = 0; j < 22; j++)
        {
            hexList[j].SetActive(true);
            currentItem = j;
            yield return new WaitForSeconds(10);
            hexList[j].SetActive(false);
        }
        
    }
}
