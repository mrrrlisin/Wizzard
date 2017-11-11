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
	   if(state == States.kidnap)
       {
            Kidnap();
       }
       if (state == States.death)
       {
            Death();
       }
    }

    void Kidnap()
    {
        mainText.text = "Тебя схватили и закинули в багажник\n" + 
            "(П)Попытаться сбежать\n (Н)Ничего не делать";
        if (Input.GetKeyDown(KeyCode.G))
        {
            state = States.death;
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            state = States.totrture;
        }
    }

    void Death()
    {
        mainText.text = "Вы попытались сбежать и вас убили.КОНЕЦ.\n(З)Заново.";
        if (Input.GetKeyDown(KeyCode.P))
        {
            state = States.kidnap;
        }
    }


}
