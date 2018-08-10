using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panel_SelectServer : MonoBehaviour {

    public GameObject ServerBotton_Red;
    public GameObject ServerBotton_Green;
    public GameObject Content_Server;
    //public Image image;

    private GameObject go;


    void Start()
    {
        InitServerMenu();
    }

    public void  InitServerMenu()
    {
        for (int i = 0; i < 16; i++)
        {
            int r = Random.Range(0, 2);
            switch (r)
            {
                case 0 : go = Instantiate(ServerBotton_Red, Content_Server.transform);
                        break;
                case 1 : go = Instantiate(ServerBotton_Green, Content_Server.transform);
                        break;
            }
            go.GetComponentInChildren<Text>().text = i + 1 + "区";
        }
    }
}
