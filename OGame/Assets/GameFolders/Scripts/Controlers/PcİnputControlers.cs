using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OGame.Controlers 
{

    public class PcinputControler
    {

        public bool LeftMouseClickDown => Input.GetMouseButtonDown(0);
        public bool RigthMouseClicDown => Input.GetMouseButtonDown(1);

    }



}
