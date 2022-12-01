using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InputKeyboardListener : MonoBehaviour, IInputeable
{
    public float butY;
    public float butX;
    public Action<Vector3> dir;
    public Vector3 direction;
    
    public void GetDirection(Vector3 direction)
    {
        InputProvider.TriggerDirection(direction);
    }
    public void ShootPressed()
    {
        InputProvider.TriggerOnHasShoot();
    }
    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            ShootPressed();
        }


        //GetDirection(new Vector3(butX, butY));
        //GetDirection(new Vector3(direction.x, direction.y));
//#if UNITY_EDITOR
//        GetDirection(new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
//#endif


    }


    public void MovementX(float valX)
    {
        direction.x = valX;
        GetDirection(direction);
    }

    public void MovementY(float valY)
    {
        direction.y = valY;
        GetDirection(direction);
    }
    //public void MoveButtonX(float val)
    //{
    //    butX = val;
    //    //butX = Mathf.Clamp(butX, -1, 1);
    //}

    //public void MoveButtonY(float val)
    //{
    //    butY = val;
    //    //butY = Mathf.Clamp(butY, -1, 1);
    //}
    //public void MoveButtonY()
    //{
    //    newDirection = new Vector3(0, 1, 0);
    //    Debug.Log("Entro al Y");

    //}


}
