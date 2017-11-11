using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Story : MonoBehaviour {
    
    enum States
    {
        kidnap,
        death,
        totrture,
        badEnd,
        goodEnd
    }
    States state = States.kidnap;
    public Text mainText; 
    void Update ()
    {
		
	}

    void Kidnap()
    {
        mainText.text = "Тебя схватили и закинули в багажник\n" + 
            "(П)Попытаться сбежать\n (Н)Ничего не делать";

    }
}
