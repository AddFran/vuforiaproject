using UnityEngine;

public class ButtonsDesp : MonoBehaviour
{
    [SerializeField] private GameObject startModel;
    private int modelsCount;
    private int indexCurrentModel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        modelsCount = transform.childCount;
        indexCurrentModel = startModel.transform.GetSiblingIndex();
    }

    public void ChangeARModel(int index)
    {
        transform.GetChild(indexCurrentModel).gameObject.SetActive(false);
        int newIndex = indexCurrentModel + index;
        if (newIndex<1)
        {
            newIndex = modelsCount - 1;
        }
        else if (newIndex > modelsCount - 1)
        {
            newIndex = 1;
        }
        GameObject newModel = transform.GetChild(newIndex).gameObject;
        newModel.SetActive(true);

        indexCurrentModel = newModel.transform.GetSiblingIndex();
    }
}
