using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Gaze : MonoBehaviour
{
    List<InfoBehavior> infos = new List<InfoBehavior>();

    void Start()
    {
        infos = FindObjectsOfType<InfoBehavior>().ToList();
    }

    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit)){
            GameObject go = hit.collider.gameObject;
                if (go.CompareTag("hasInfo")){
                    OpenInfo(go.GetComponent<InfoBehavior>());
                }
        } else {
            CloseAll();
        }
        
    }

    void OpenInfo(InfoBehavior desiredInfo) {
        foreach (InfoBehavior info in infos) {
            if (info == desiredInfo) {
                info.OpenInfo();
            } else{
                info.CloseInfo();
            }
        }
    }

    void CloseAll()
    {
        foreach (InfoBehavior info in infos) {
            info.CloseInfo();
        }
    }
}
