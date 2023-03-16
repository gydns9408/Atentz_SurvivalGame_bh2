using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Test_Pool : Test_Base
{


    void Start() 
    {

    }

    protected override void DoAction1(InputAction.CallbackContext _)
    {
        GameObject obj = ItemManager.Instance.GetObject(ItemType.Strawberry); // Tomato ���ӿ�����Ʈ�� ItemManager���� ������ Ȱ��ȭ
        obj.transform.position = Vector3.up * 9;
    }

    protected override void DoAction2(InputAction.CallbackContext _)
    {
        GameObject obj = ItemManager.Instance.GetObject(ItemType.Avocado); // Strawberry ���ӿ�����Ʈ�� ItemManager���� ������ Ȱ��ȭ
        obj.transform.position = Vector3.up * 9;
    }

    protected override void DoAction3(InputAction.CallbackContext _)
    {
        GameObject obj = ItemManager.Instance.GetObject(ItemType.Peanut); // Potato ���ӿ�����Ʈ�� ItemManager���� ������ Ȱ��ȭ
        obj.transform.position = Vector3.up * 9;
    }

    protected override void DoAction4(InputAction.CallbackContext _)
    {
        bool inventoryAlreadyhave = false; // ������ �κ��丮�� Ư�� �������� �ִ��� ���θ� Ȯ���ϴ� bool ����
        for (int i = 0; i < ItemManager.Instance.itemInventory.emptySpaceStartIndex; i++) { 
            if (ItemManager.Instance.itemInventory.ItemTypeArray[i] == ItemType.Strawberry) 
            {
                ItemManager.Instance.itemInventory.ItemAmountArray[i] += 1;
                inventoryAlreadyhave = true;
                break;
            } //������ �κ��丮���� Strawberry�� �ִ��� �˻��ϰ� �ִٸ�, �� ��ġ�� ���� 1�� �߰�
        }
        if (!inventoryAlreadyhave) // ���� ������ �κ��丮�� Strawberry�� ���ٸ�
        {
            if (ItemManager.Instance.itemInventory.emptySpaceStartIndex < ItemManager.Instance.itemInventoryMaxSpace) // �׸��� ���� ������ �κ��丮�� �� ���� �ʾҴٸ�
            {
                ItemManager.Instance.itemInventory.ItemTypeArray[ItemManager.Instance.itemInventory.emptySpaceStartIndex] = ItemType.Strawberry; 
                ItemManager.Instance.itemInventory.ItemAmountArray[ItemManager.Instance.itemInventory.emptySpaceStartIndex] += 1;
                ItemManager.Instance.itemInventory.emptySpaceStartIndex++; // ������ �κ��丮�� Strawberry�� �߰��� ��  �� Strawberry�� ������ 1�� �߰�
            }
        }
        ItemInventoryWindow itemInventoryWindow = FindObjectOfType<ItemInventoryWindow>();
        itemInventoryWindow.RefreshItemInventory();
        Debug.Log(ItemManager.Instance.itemInventory.ItemAmountArray[0]); // ������ �κ��丮 0��° ĭ�� �ִ� �������� ���� ���
        Debug.Log(ItemManager.Instance[ItemType.Strawberry].ItemName); // Strawberry�� (�ѱ�)�̸� ���
        Debug.Log(ItemManager.Instance[ItemType.Strawberry].Explan); // Strawberry�� ���� ���
        Debug.Log(ItemManager.Instance[ItemType.Strawberry].AmountOfHungerRecovery); // Strawberry�� ���ȸ���� ���
    }

    protected override void DoAction5(InputAction.CallbackContext _)
    {
        bool inventoryAlreadyhave = false; // ������ �κ��丮�� Ư�� �������� �ִ��� ���θ� Ȯ���ϴ� bool ����
        for (int i = 0; i < ItemManager.Instance.itemInventory.emptySpaceStartIndex; i++)
        {
            if (ItemManager.Instance.itemInventory.ItemTypeArray[i] == ItemType.Avocado)
            {
                ItemManager.Instance.itemInventory.ItemAmountArray[i] += 1;
                inventoryAlreadyhave = true;
                break;
            } //������ �κ��丮���� Avocado�� �ִ��� �˻��ϰ� �ִٸ�, �� ��ġ�� ���� 1�� �߰�
        }
        if (!inventoryAlreadyhave) // ���� ������ �κ��丮�� Avocado�� ���ٸ�
        {
            if (ItemManager.Instance.itemInventory.emptySpaceStartIndex < ItemManager.Instance.itemInventoryMaxSpace) // �׸��� ���� ������ �κ��丮�� �� ���� �ʾҴٸ�
            {
                ItemManager.Instance.itemInventory.ItemTypeArray[ItemManager.Instance.itemInventory.emptySpaceStartIndex] = ItemType.Avocado;
                ItemManager.Instance.itemInventory.ItemAmountArray[ItemManager.Instance.itemInventory.emptySpaceStartIndex] += 1;
                ItemManager.Instance.itemInventory.emptySpaceStartIndex++; // ������ �κ��丮�� Avocado�� �߰��� ��  �� Avocado�� ������ 1�� �߰�
            }
        }
        ItemInventoryWindow itemInventoryWindow = FindObjectOfType<ItemInventoryWindow>();
        itemInventoryWindow.RefreshItemInventory();
        //SceneManager.LoadScene("SampleScene2");
    }
}
