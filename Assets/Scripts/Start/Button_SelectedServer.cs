using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_SelectedServer : MonoBehaviour {

    public GameObject Start_Button_Server;
    private GameObject btn_SelectedServer;

    private void Start()
    {
        gameObject.GetComponentInChildren<Text>().text = Start_Button_Server.GetComponentInChildren<Text>().text;
    }

    public void OnButton_SelectedServerClick()
    {
        //start的server按钮改成选择的服务器
        Start_Button_Server.GetComponentInChildren<Text>().text = gameObject.GetComponentInChildren<Text>().text;
    }
    public void SelectServer()
    {
        btn_SelectedServer = GameObject.Find("Button_SelectedServer");
        btn_SelectedServer.GetComponent<Image>().sprite = gameObject.GetComponent<Image>().sprite;
        btn_SelectedServer.GetComponentInChildren<Text>().text = gameObject.GetComponentInChildren<Text>().text;
        btn_SelectedServer.GetComponentInChildren<Text>().color = gameObject.GetComponentInChildren<Text>().color;
    }
}
