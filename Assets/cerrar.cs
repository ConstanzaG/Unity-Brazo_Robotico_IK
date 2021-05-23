using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cerrar : MonoBehaviour
{
    public Transform cuerpo;
    public Transform cuerpo1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("m") & cuerpo.localPosition.x < -0.3 )
        {
            cuerpo.localPosition += new Vector3(0.01f, 0, 0);
            cuerpo1.localPosition -= new Vector3(0.01f, 0, 0);
        }
        
        if (Input.GetKey("n") & cuerpo.localPosition.x > -1)
        {
            cuerpo1.localPosition += new Vector3(0.01f, 0, 0);
            cuerpo.localPosition -= new Vector3(0.01f, 0, 0);
        }
    }
}
