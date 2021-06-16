using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Joint : MonoBehaviour
{
    public Joint m_child;
    public string DireccionRotacion;

    public Joint GetChild()
    {
        return m_child;
    }

    // Start is called before the first frame update
    public void Rotar(float _angle) 
    {
        
        if(DireccionRotacion.ToUpper() == "UP")
        {
            this.transform.Rotate(Vector3.down * _angle);

        }
        else if(DireccionRotacion.ToUpper() == "DOWN")
        {
            this.transform.Rotate(Vector3.down * _angle);

        }
        else if(DireccionRotacion.ToUpper() == "FORWARD")
        {
            this.transform.Rotate(Vector3.forward * _angle);

        }
        else if(DireccionRotacion.ToUpper() == "BACK")
        {
            this.transform.Rotate(Vector3.back * _angle);
        }
        else if(DireccionRotacion.ToUpper() == "RIGHT")
        {
            this.transform.Rotate(Vector3.right * _angle);
        }
        else if(DireccionRotacion.ToUpper() == "LEFT")
        {
            this.transform.Rotate(Vector3.left * _angle);
        }
    }
}
