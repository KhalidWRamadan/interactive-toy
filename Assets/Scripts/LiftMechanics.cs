using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
namespace InteractiveToy
{

    public class LiftMechanics : MonoBehaviour
    {
        public bool isOn = false;
        private float x;
        // public bool IsOn
        // {
        //     get;
        // }
        // Start is called before the first frame update
        void Start()
        {
            x = transform.eulerAngles.x;
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (isOn) isOn = false;
                else isOn = true;
                x = x * -1f;
                Debug.Log(x);
                transform.rotation = Quaternion.Euler(new Vector3(x, 0, 0));
            }


        }
    }
}
