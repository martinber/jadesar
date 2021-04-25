using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.XR.ARFoundation;

public class SpawnableManager : MonoBehaviour
{
    public ARRaycastManager m_RaycastManager;
    List<ARRaycastHit> m_Hits = new List<ARRaycastHit>();
    public GameObject spawnablePrefab;

    GameObject spawnedObject;

    void Start()
    {
        spawnedObject = null;
    }

    void Update()
    {
        if (Input.touchCount == 0)
        {
            return;
        }

        if (m_RaycastManager.Raycast(Input.GetTouch(0).position, m_Hits))
        {
            if (spawnedObject == null) {
                spawnedObject = Instantiate(
                        spawnablePrefab,
                        m_Hits[0].pose.position,
                        Quaternion.identity
                    );
            }

            spawnedObject.transform.position = m_Hits[0].pose.position;
        }
    }
}
