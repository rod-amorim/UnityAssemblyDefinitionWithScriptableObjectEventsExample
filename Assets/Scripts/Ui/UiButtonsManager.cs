using Core.ScriptableObjects;
using UnityEngine;

namespace Ui.Ui
{
    public class UiButtonsManager : MonoBehaviour
    {
        [SerializeField] private WalletManagerScriptableObject walletManagerScriptableObject;
        
        public void AddMoney(int amount)
        {
            walletManagerScriptableObject.AddMoney(amount);
        }

        public void RemoveMoney(int amount)
        {
            walletManagerScriptableObject.RemoveMoney(amount);
        }
    }
}