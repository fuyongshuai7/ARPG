using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel_CharacterShowSelect : MonoBehaviour {

    public static GameObject go_CharacterSelected;

    void OnMouseUpAsButton()
    {
        iTween.ScaleTo(this.gameObject, new Vector3(1.5f, 1.5f, 1.5f), 0.5f);
        if(go_CharacterSelected != null && go_CharacterSelected != this.gameObject)
        {
            iTween.ScaleTo(go_CharacterSelected, new Vector3(1f, 1f, 1f), 0.5f);
        }
        go_CharacterSelected = this.gameObject;
    }

}
