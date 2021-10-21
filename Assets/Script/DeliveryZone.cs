using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliveryZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player"){
            PlayerController pc = other.gameObject.GetComponent<PlayerController>();
            pc.CheckCaddie();
        }
    }
}
