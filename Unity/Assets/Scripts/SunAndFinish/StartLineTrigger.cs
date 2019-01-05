using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLineTrigger : MonoBehaviour
{
        // Start is called before the first frame update
        private void OnTriggerEnter(Collider other)
        {
            GameObject.Find("Car").SendMessage("TimeStart");
        }
}
