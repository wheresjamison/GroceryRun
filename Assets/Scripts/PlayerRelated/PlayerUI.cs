using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI promptText;

    [SerializeField] public GameObject inventoryWindow;
    [SerializeField] public GameObject minimapWindow;
    [SerializeField] public GameObject questWindow;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void UpdateText(string promptMessage)
    {
        promptText.text = promptMessage;
    }

    public void OpenInventory()
    {
        inventoryWindow.SetActive(true);
    }
    public void CloseInventory()
    {
        inventoryWindow.SetActive(false);
    }
    public void OpenMinimap()
    {
        minimapWindow.SetActive(true);
    }
    public void CloseMinimap()
    {
        minimapWindow.SetActive(false);
    }
    public void OpenQuest()
    {
        questWindow.SetActive(true);
    }
    public void CloseQuest()
    {
        questWindow.SetActive(false);
    }
}
