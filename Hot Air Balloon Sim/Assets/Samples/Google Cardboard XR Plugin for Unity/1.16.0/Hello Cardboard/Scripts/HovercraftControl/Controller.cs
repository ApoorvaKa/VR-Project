using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public GameObject hotAirBalloon;

    public bool isForward;
    public bool isBackward;
    public bool isUp;
    public bool isDown;
    public bool isRight;
    public bool isLeft;

    private void OnPointerEnter()
    {
        GetComponent<Renderer>().material.color = Color.blue;
    }

    private void OnPointerExit()
    {
        GetComponent<Renderer>().material.color = Color.white;
    }

    private void OnPointerClick()
    {
        GetComponent<Renderer>().material.color = Color.green;

        if (isForward)
        {
            hotAirBalloon.GetComponent<PlayerMovement>().MoveForward();
        }
        else if (isBackward)
        {
            hotAirBalloon.GetComponent<PlayerMovement>().MoveBackward();
        }
        else if (isUp)
        {
            hotAirBalloon.GetComponent<PlayerMovement>().MoveUp();
        }
        else if (isDown){
            hotAirBalloon.GetComponent<PlayerMovement>().MoveDown();
        }
        else if (isRight)
        {
            hotAirBalloon.GetComponent<PlayerMovement>().MoveRight();
        }
        else if (isLeft)
        {
            hotAirBalloon.GetComponent<PlayerMovement>().MoveLeft();
        }
    }
}
