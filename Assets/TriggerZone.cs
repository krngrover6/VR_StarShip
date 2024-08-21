using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerZone : MonoBehaviour
{
    // Start is called before the first frame update
   public string targetTag;
   public UnityEvent<GameObject> OnEnterEvent;

   private void OnTriggerEnter(Collider Other)
   {
        if(Other.gameObject.tag == targetTag)
        {
            OnEnterEvent.Invoke(Other.gameObject);
        }
   }
   // basically it tells that the object has entered the collider
}