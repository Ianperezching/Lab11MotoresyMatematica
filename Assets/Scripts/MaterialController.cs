using UnityEngine;
using UnityEngine.Events;

public class MaterialController : MonoBehaviour
{
    public DynamicMaterialData dynamicMaterialData;    
    public Material targetMaterial;                   
    public UnityEvent onMaterialChangeEvent;          

    private void Start()
    {
        if (targetMaterial != null && dynamicMaterialData != null)
        {
            dynamicMaterialData.ApplyToMaterial(targetMaterial);
        }
    }

    
    public void ChangeMaterial()
    {
        if (targetMaterial != null && dynamicMaterialData != null)
        {
            dynamicMaterialData.ApplyToMaterial(targetMaterial);
            onMaterialChangeEvent?.Invoke();  
        }
    }
}
