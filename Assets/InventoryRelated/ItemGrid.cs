using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGrid : MonoBehaviour
{
    public const float tileSizeWidth = 16;
    public const float tileSizeHeight = 16;

    InventoryItem[,] inventoryItemSlot;

    RectTransform rectTransform;

    Vector2 positionOnTheGrid = new Vector2();
    Vector2Int tileGridPosition = new Vector2Int();

    [SerializeField]
    int gridSizeWidth = 5;
    [SerializeField]
    int gridSizeHeight = 4 ;

    //[SerializeField] GameObject inventoryItemPrefab;

    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        Init(gridSizeWidth,gridSizeHeight);

        //item testing 1x1s
        //InventoryItem inventoryItem = Instantiate(inventoryItemPrefab).GetComponent<InventoryItem>();
        //PlaceItem(inventoryItem, 3, 2);
        //
        //inventoryItem = Instantiate(inventoryItemPrefab).GetComponent<InventoryItem>();
        //PlaceItem(inventoryItem, 2, 1);
        //
        //inventoryItem = Instantiate(inventoryItemPrefab).GetComponent<InventoryItem>();
        //PlaceItem(inventoryItem, 0, 0);
    }

    public InventoryItem PickUpItem(int x, int y)
    {
        InventoryItem toReturn = inventoryItemSlot[x, y];
        inventoryItemSlot[x, y] = null;
        return toReturn;
    }

    private void Init(int width, int height)
    {
        inventoryItemSlot = new InventoryItem[width, height];
        Vector2 size = new Vector2(width * tileSizeWidth, height * tileSizeHeight);
        rectTransform.sizeDelta = size;
    }

    public Vector2Int GetTileGridPosition(Vector2 mousePosition)
    {
        positionOnTheGrid.x = mousePosition.x - rectTransform.position.x;
        positionOnTheGrid.y = rectTransform.position.y - mousePosition.y;

        tileGridPosition.x = (int)(positionOnTheGrid.x / tileSizeWidth);
        tileGridPosition.y = (int)(positionOnTheGrid.y / tileSizeHeight);

        return tileGridPosition;
    }

    public void PlaceItem(InventoryItem inventoryItem, int xPos, int yPos)
    {
        RectTransform rectTransform = inventoryItem.GetComponent<RectTransform>();
        rectTransform.SetParent(this.rectTransform);
        inventoryItemSlot[xPos, yPos] = inventoryItem;

        Vector2 position = new Vector2();
        position.x = xPos * tileSizeWidth + tileSizeWidth / 2;
        position.y = -(yPos * tileSizeHeight + tileSizeHeight / 2);

        rectTransform.localPosition = position;
    }
}
