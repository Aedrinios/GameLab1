using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayManager : MonoBehaviour
{
    [SerializeField]
    Transform tpposition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("Hit !");
                if (hit.transform.gameObject.tag == "Item"){
                    hit.transform.position = tpposition.position;
                    Itemcontroller Ic = hit.transform.gameObject.GetComponent <Itemcontroller>();
                    if (Ic != null){
                        Ic.setParent(tpposition);
                    }
                }

            }
            else
            {
                Debug.Log("No hit !");
            }
        }
    }
}
