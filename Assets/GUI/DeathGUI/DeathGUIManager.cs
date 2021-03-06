using System.Collections;
using UnityEngine;

public class DeathGUIManager : MonoBehaviour
{
    [SerializeField] private Character character;
    [SerializeField] private GameObject deathGUI;
    [SerializeField] private float timeToDeathGuiActivation = 2f;

    public void FixedUpdate()
    {
        ActiveDeathGUIIFCharacterIsDead();
    }

    private void ActiveDeathGUIIFCharacterIsDead()
    {
        if (character.IsDead && deathGUI.active == false)
        {
            StartCoroutine(GUIActivationAfterTimeProcess(timeToDeathGuiActivation));
        }
    }

    private IEnumerator GUIActivationAfterTimeProcess(float time)
    {
        yield return new WaitForSeconds(time);
        deathGUI.SetActive(true);
    }
}
