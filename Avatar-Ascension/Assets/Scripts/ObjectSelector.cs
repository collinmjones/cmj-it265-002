using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSelector : MonoBehaviour
{

    [SerializeField] private Camera cam;
     [SerializeField] private GameObject selected;

    private void Awake(){
        var c = GetComponent<Camera>();
        if (c != null && cam == null){
            cam = c;
        }
        
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){ 
            Debug.Log("User clicked the left mouse button");
            Vector2 worldPoint = Camera.main.ScreenToWorldPoint( Input.mousePosition );
            RaycastHit2D hit = Physics2D.Raycast( worldPoint, Vector2.zero );
        if ( hit.collider != null )
        {
            Debug.Log(hit.collider.name);
        }
        }
    }
}
