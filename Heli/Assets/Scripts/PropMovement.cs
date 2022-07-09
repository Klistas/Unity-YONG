using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropMovement : MonoBehaviour
{
    private HeliInput _heliInput;

    public GameObject Propeller;
    public GameObject TailPropeller;
   

    public float PropSpeed = 0.0f;
    public float MinPropSpeed = 0.0f;
    public float MaxPropSpeed = 10.0f;
    public float getOnDeltaTime = 0.0f;
    public float getOffDeltaTime = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        _heliInput = GetComponent<HeliInput>();
       
    }

    // Update is called once per frame
    void Update()
    {

      
        if(_heliInput.OnButton == true)
        {
            PropSpeed = Mathf.Lerp(MinPropSpeed, MaxPropSpeed, getOnDeltaTime);
            getOnDeltaTime += 0.1f * Time.deltaTime;
            Propeller.transform.Rotate(new Vector3(0, PropSpeed, 0));
            TailPropeller.transform.Rotate(new Vector3(0, PropSpeed, 0));
            getOffDeltaTime = 0f;
        }
       else
        {
            PropSpeed = Mathf.Lerp(PropSpeed, MinPropSpeed, getOffDeltaTime);
            getOffDeltaTime += 0.001f * Time.deltaTime;
            Propeller.transform.Rotate(new Vector3(0, PropSpeed, 0));
            TailPropeller.transform.Rotate(new Vector3(0, PropSpeed, 0));
            getOnDeltaTime = 0f;

        }
      
        
        
    }
}
