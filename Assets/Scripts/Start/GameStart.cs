using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameStart : MonoBehaviour {

    public Text Start_ButtonName_Text;
    public InputField Login_InputField_Account;
    public InputField Register_InputField_Account;

    //button_SelectServer iTween Scale To
    public void iTweenScaleTo_SelectServer_Big()
    {
        iTweenEvent.GetEvent(gameObject, "iTween_Server_ScalesToBig").Play();
    }
    public void iTweenScaleTo_SelectServer_Small()
    {
        iTweenEvent.GetEvent(gameObject, "iTween_Server_ScalesToSmall").Play();
    }

    //button_enter iTween Scale To
    public void iTweenScaleTo_ButtonEnter_Small()
    {
        iTweenEvent.GetEvent(gameObject, "iTween_Start_ScalesToSmall").Play();
    }
    public void iTweenScaleTo_ButtonEnter_Big()
    {
        iTweenEvent.GetEvent(gameObject, "iTween_Start_ScalesToBig").Play();
    }

    //Login iTween Scale To
    public void iTweenScaleTo_Login_Big()
    {
        iTweenEvent.GetEvent(gameObject, "iTween_Login_ScalesToBig").Play();
    }
    public void iTweenScaleTo_Login_Small()
    {
        iTweenEvent.GetEvent(gameObject, "iTween_Login_ScalesToSmall").Play();
    }

    //Login Button_Login
    public void Login_ButtonLogin_Click()
    {
        //验证用户名与密码是否正确
        //正确：InputFiled_Account.text 赋值给start button_name text,返回start
        Start_ButtonName_Text.text = Login_InputField_Account.text;

        //失败:
    }


    //Register iTween Scale To
    public void iTweenScaleTo_Register_Big()
    {
        iTweenEvent.GetEvent(gameObject, "iTween_Register_ScalesToBig").Play();
    }   
    public void iTweenScaleTo_Register_Small()
    {
        iTweenEvent.GetEvent(gameObject, "iTween_Register_ScalesToSmall").Play();
    }

    //Register and login
    public void Register_Button_RegisterAndLogin_Click()
    {
        //验证用户名是否重复
        //验证密码是否正确
        //正确：register InputFiled_Account.text 赋值给start button_name text跟login InputFiled_Account.text 返回start
        Start_ButtonName_Text.text = Register_InputField_Account.text;
        Login_InputField_Account.text = Register_InputField_Account.text;
        //失败
    }

    //server select
    public void SelecetedServer()
    {
       // //copy myselef
       // button_SelectedServer = GameObject.Find("Button_SelectedServer");
       // GameObject sb = Instantiate(gameObject, button_SelectedServer.transform);
       //// sb.GetComponent<Image>().SetNativeSize();
    }


    //CharacterSelect iTween MoveTo
    public void iTweenMoveTo_CharacterSelect_0()
    {
        iTweenEvent.GetEvent(gameObject, "iTween_CharacterSelect_MoveTo0").Play();
    }
    public void iTweenMoveTo_CharacterSelect_Back()
    {
        iTweenEvent.GetEvent(gameObject, "iTween_CharacterSelect_MoveToBack").Play();
        StartCoroutine(iTweenBackEnd());
    }

    //CharacterShowSelect iTween MoveTo
    public void iTweenMoveTo_CharacterShowSelect()
    {
        iTweenEvent.GetEvent(gameObject, "iTween_CharacterShowSelect_MoveTo").Play();
    }
    public void iTweenMoveTo_CharacterShowSelect_Back()
    {
        iTweenEvent.GetEvent(gameObject, "iTween_CharacterShowSelect_MoveToBack").Play();
        StartCoroutine(iTweenBackEnd());
    }

    IEnumerator iTweenBackEnd()
    {
        yield return new WaitForSeconds(0.6f);
        gameObject.SetActive(false);
    }
}
