using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public GameObject[] Cameras;

    // Keyboard input changed from string keys to KeyCode values.
    // This is clearer and avoids legacy string-based key handling.
    private static readonly KeyCode[] NumberKeys =
    {
        KeyCode.Alpha1,
        KeyCode.Alpha2,
        KeyCode.Alpha3,
        KeyCode.Alpha4,
        KeyCode.Alpha5,
        KeyCode.Alpha6,
        KeyCode.Alpha7,
        KeyCode.Alpha8,
        KeyCode.Alpha9
    };

    void Update()
    {
        for (int i = 0; i < Cameras.Length && i < NumberKeys.Length; i++)
        {
            if (!Input.GetKeyDown(NumberKeys[i]))
                continue;

            foreach (var cameraObject in Cameras)
            {
                cameraObject.SetActive(false);
            }

            Cameras[i].SetActive(true);
        }
    }
}
