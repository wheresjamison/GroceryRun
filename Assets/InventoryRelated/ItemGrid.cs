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

        if (toReturn == null)
        {
            return null;
        }

        CleanGridReference(toReturn);
        
        //inventoryItemSlot[x, y] = null;
        return toReturn;
    }

    private void CleanGridReference(InventoryItem item)
    {
        for (int ix = 0; ix < item.WIDTH; ix++)
        {
            for (int iy = 0; iy < item.HEIGHT; iy++)
            {
                inventoryItemSlot[item.onGridPositionX + ix, item.onGridPositionY + iy] = null;
            }
        }
    }

    internal InventoryItem GetItem(int x, int y)
    {
        return inventoryItemSlot[x, y];
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


    //vector2int is normally not null-able. so add ? todo that.
    public Vector2Int? FindSpaceForObject(InventoryItem itemToInsert)
    {
        int height = gridSizeHeight - itemToInsert.HEIGHT +1 ;
        int width = gridSizeWidth - itemToInsert.WIDTH+1;

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                if(CheckAvailableSpace(x,y,itemToInsert.WIDTH, itemToInsert.HEIGHT) == true)
                {
                    return new Vector2Int(x, y);
                }
            }
        }
        return null;
    }

    public bool PlaceItem(InventoryItem inventoryItem, int xPos, int yPos, ref InventoryItem overlapItem)
    {
        if (BoundaryCheck(xPos, yPos, inventoryItem.WIDTH, inventoryItem.HEIGHT)==false)
        {
            return false;
        }

        if (OverlapCheck(xPos,yPos,inventoryItem.WIDTH, inventoryItem.HEIGHT,ref overlapItem) == false)
        {
            overlapItem = null;
            return false;
        }

        if(overlapItem != null)
        {
            CleanGridReference(overlapItem);
        }

        PlaceItem(inventoryItem, xPos, yPos);

        return true;
    }

    public void PlaceItem(InventoryItem inventoryItem, int xPos, int yPos)
    {
        RectTransform rectTransform = inventoryItem.GetComponent<RectTransform>();
        rectTransform.SetParent(this.rectTransform);

        for (int x = 0; x < inventoryItem.WIDTH; x++)
        {
            for (int y = 0; y < inventoryItem.HEIGHT; y++)
            {
                inventoryItemSlot[xPos, yPos + y] = inventoryItem;

            }
        }

        inventoryItem.onGridPositionX = xPos;
        inventoryItem.onGridPositionY = yPos;

        //here
        Vector2 position = CalculatePositionOnGrid(inventoryItem, xPos, yPos);

        rectTransform.localPosition = position;
    }

    public Vector2 CalculatePositionOnGrid(InventoryItem inventoryItem, int xPos, int yPos)
    {
        Vector2 position = new Vector2();
        position.x = xPos * tileSizeWidth + tileSizeWidth * inventoryItem.WIDTH / 2;
        position.y = -(yPos * tileSizeHeight + tileSizeHeight * inventoryItem.HEIGHT / 2);
        return position;
    }

    private bool OverlapCheck(int xPos, int yPos, int width, int height, ref InventoryItem overlapItem)
    {
        for (int x =0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                if (inventoryItemSlot[xPos+x,yPos+y]!= null)
                {
                    if(overlapItem == null)
                    {
                        overlapItem = inventoryItemSlot[xPos + x, yPos + y];
                    }
                    else
                    {
                        if(overlapItem != inventoryItemSlot[xPos+x, yPos + y])
                        {
                            return false;
                        }
                    }
                }
            }
        }
        
        return true;
    }

    private bool CheckAvailableSpace(int xPos, int yPos, int width, int height)
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                if (inventoryItemSlot[xPos + x, yPos + y] != null)
                {
                    return false;
                }
            }
        }

        return true;
    }

    bool PositionCheck(int xPos, int yPos)
    {
        if(xPos < 0 || yPos < 0)
        {
            return false;
        }
        if (xPos >= gridSizeWidth || yPos >= gridSizeHeight)
        {
            return false;
        }
        return true;
    }
    public bool BoundaryCheck(int xPos, int yPos, int width, int height)
    {
        if(PositionCheck(xPos,yPos) == false)
        {
            return false;
        }

        xPos += width-1;
        yPos += height-1;

        if(PositionCheck(xPos,yPos) == false)
        {
            return false;
        }

        return true;
    }
}
