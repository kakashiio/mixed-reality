using TMPro;
using UnityEngine;

public class Main : MonoBehaviour
{
    public TextMeshProUGUI FrameLabel;
    public TextMeshProUGUI CountLabel;

    private int _ClickCount;

    void Update()
    {
        _TestInput();
    }

    private void _TestInput()
    {
        FrameLabel.text = Time.frameCount.ToString();
        CountLabel.text = _ClickCount.ToString();
        
        
        if (OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.LTouch) ||
            OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch))
        {
            _ClickCount++;
            Debug.Log("Click " + _ClickCount);
            OVRInput.SetControllerVibration(1, 1, OVRInput.Controller.RTouch);
        }
    }
}
