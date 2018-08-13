using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterShowSlect_Button_Sure : MonoBehaviour {

    public InputField CharacterShowSelectInputField;
    public Text CharacterSelectName;
    public Text CharacterSelectLv;
    public GameObject CharacterSelect_ybot;
    public GameObject CharacterSelect_girl;

    public void OnCharacterShowSlect_Button_SureClick()
    {
        CharacterSelectName.text = CharacterShowSelectInputField.text;
        CharacterSelectLv.text = "Lv 1";

        GameObject go = Panel_CharacterShowSelect.go_CharacterSelected;
        if (go.name == CharacterSelect_ybot.name)
        {
            CharacterSelect_ybot.SetActive(true);
            CharacterSelect_girl.SetActive(false);
        }
        else if(go.name == CharacterSelect_girl.name)
        {
            CharacterSelect_ybot.SetActive(false);
            CharacterSelect_girl.SetActive(true);
        }
    }
}
