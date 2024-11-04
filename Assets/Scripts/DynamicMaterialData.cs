using UnityEngine;

[CreateAssetMenu(fileName = "DynamicMaterialData", menuName = "Custom/DynamicMaterialData")]
public class DynamicMaterialData : ScriptableObject
{
    public Color baseColor = Color.white;     
    public float brightness = 1.0f;          
    public float textureScale = 1.0f;

 
    public void ApplyToMaterial(Material material)
    {
        material.SetColor("_Color", baseColor);
        material.SetFloat("_Brightness", brightness);
        material.mainTextureScale = new Vector2(textureScale, textureScale);
    }
}