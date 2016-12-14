using UnityEngine;
using System.Collections;



    /*
    <summary>
    Starts the animation at random time
    </summary>
    */

    public class StartApplause : MonoBehaviour
    {
        /*
        <summary>
        Index of the layer of the default state
        </summary>
        */
        [Tooltip("Index of the layer of the default state")]
        public int _layerIndex = 0;
        
        void Start()
        {

        Invoke("startAnimation", Random.Range(0f,3f));
            
        
        }

    private void startAnimation()
    {
       
   
        GetComponent<Animation>().Play();
    }
        
    }
