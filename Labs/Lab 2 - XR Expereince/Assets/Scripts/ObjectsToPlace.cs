using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ObjectsToPlace : MonoBehaviour
{
    public GameObject objectsToPlace;
    public ARRaycastManager arRaycastManager;
    public GameObject cursor;
    public bool useCursor;

    private GameObject currentObject;

    public Camera ARCamer;
    // Start is called before the first frame update
    void Start()
    {
        
    }
 
    // Update is called once per frame
    void Update()
    {

        if (useCursor)
        {
            Vector2 screenPosition = ARCamer.ViewportToScreenPoint(new Vector2(0.5f, 0.5f));
            List<ARRaycastHit> hits = new List<ARRaycastHit>();
            arRaycastManager.Raycast(screenPosition, hits, TrackableType.Planes);
            if (hits.Count > 0)
            {
                cursor.transform.position = hits[0].pose.position;
            }
        }
        
        if (Input.GetTouch(0).phase == TouchPhase.Began && !isPointerOverUIObject(Input.GetTouch(0)))
        {
            if (useCursor)
            {
                currentObject = Instantiate(objectsToPlace, cursor.transform.position, cursor.transform.rotation);
                currentObject.transform.rotation = Quaternion.identity; 
               
            }

            else
            {
                List<ARRaycastHit> hits = new List<ARRaycastHit>();
                arRaycastManager.Raycast(Input.GetTouch(0).position, hits, TrackableType.Planes);
                currentObject = Instantiate(objectsToPlace, hits[0].pose.position, hits[0].pose.rotation);
            }
            
        }
    }

    public bool isPointerOverUIObject(Touch touch)
    {
        PointerEventData eventPosition = new PointerEventData(EventSystem.current);
        eventPosition.position = new Vector2(touch.position.x, touch.position.y);

        List <RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventPosition, results);

        return results.Count > 0;
    }

    public void scaleUp()
    {
        currentObject.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
    }
    
    public void scaleDown()
    {
        currentObject.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
    }
}
