using UnityEngine;

public class SkinChanger : MonoBehaviour
{
    [SerializeField]
    private MaterialPool materialPool;
    
    public MeshRenderer prefMeshRenderer;
    private MeshRenderer meshRenderer;

    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material = materialPool.GetCurrentMaterial();
    }


    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            Material tempMaterialPrev = materialPool.GetPrevousMaterial();
            prefMeshRenderer.material = tempMaterialPrev;
            meshRenderer.material = tempMaterialPrev;
        }

        if (Input.GetKeyDown(KeyCode.D)) {
            Material tempMaterialNext = materialPool.GetNextMaterial();
            prefMeshRenderer.material = tempMaterialNext;
            meshRenderer.material = tempMaterialNext;
        }

    }
}
