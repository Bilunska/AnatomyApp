using UnityEngine;

public class InfoBehavior : MonoBehaviour
{
    const float SPEED = 6f;

    [SerializeField]
    Transform SectionInfo;
    [SerializeField]
    Transform SectionInfo2;
    
    Vector3 desiredScale = Vector3.zero;
    
    // Update is called once per frame
    void Update()
    {
        SectionInfo.localScale = Vector3.Lerp(SectionInfo.localScale, desiredScale, Time.deltaTime * SPEED);
        SectionInfo2.localScale = Vector3.Lerp(SectionInfo2.localScale, desiredScale, Time.deltaTime * SPEED);
    }

    public void OpenInfo()
    {
        desiredScale = Vector3.one;
    }

    public void CloseInfo()
    {
        desiredScale = Vector3.zero;
    }
}
