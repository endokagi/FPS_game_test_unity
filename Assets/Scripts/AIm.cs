using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIm : MonoBehaviour
{

    public Transform GunContainer, ADS;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(1)) Ads();
        if(!Input.GetMouseButton(1)) non_Ads();
    }

    private void Ads(){
        transform.SetParent(ADS);   
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.Euler(Vector3.zero);
    }

    private void non_Ads(){
        transform.SetParent(GunContainer);
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.Euler(Vector3.zero);
    }
}
