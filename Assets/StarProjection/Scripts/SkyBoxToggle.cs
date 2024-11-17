using UnityEngine;
using UnityEngine.UI;


public class SkyboxToggle : MonoBehaviour
{
    public Material skyboxMaterial;
    private bool isSkyboxActive = true;
    public Image image;

    public void ToggleSkybox()
    {
        if (isSkyboxActive)
        {
            RenderSettings.skybox = null;
            Camera.main.clearFlags = CameraClearFlags.SolidColor;
            image.GetComponent<Image>().color = new Color32(255, 0, 0, 100);
        }
        else
        {
            RenderSettings.skybox = skyboxMaterial;
            Camera.main.clearFlags = CameraClearFlags.Skybox;
            image.GetComponent<Image>().color = new Color32(255, 255, 255, 100);
        }
        isSkyboxActive = !isSkyboxActive;
    }
}