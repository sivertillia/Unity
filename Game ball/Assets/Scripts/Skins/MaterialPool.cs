using UnityEngine;

public class MaterialPool : MonoBehaviour
{
    [SerializeField]
    private Material[] materialPool;

    private int index = 0;

    public Material GetNextMaterial()
    {
        if (materialPool.Length == 0)
            Debug.LogError("Pool is empty");
        if (index + 1 < materialPool.Length)
        {
            index++;
            return materialPool[index];
        }
        else
        {
            index = 0;
            return materialPool[index];
        }

    }

    public Material GetPrevousMaterial()
    {
        if (materialPool.Length == 0)
            Debug.LogError("Pool is empty");
        if (index - 1 >= 0)
        {
            index--;
            return materialPool[index];
        }
        else
        {
            index = materialPool.Length - 1;
            return materialPool[index];
        }
    }

    public Material GetCurrentMaterial()
    {
        if (materialPool.Length == 0)
            Debug.LogError("Pool is empty");
        return materialPool[index];
    }
}
