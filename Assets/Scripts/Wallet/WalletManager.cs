using Core.ScriptableObjects;
using TMPro;
using UnityEngine;

namespace Wallet.Wallet
{
    public class WalletManager : MonoBehaviour
    {
        [SerializeField] private WalletManagerScriptableObject walletManagerScriptableObject;
        [SerializeField] private TextMeshProUGUI moneyText;

        // Start is called before the first frame update
        void Start()
        {
            moneyText.text = "0";
        }

        private void OnEnable()
        {
            walletManagerScriptableObject.ChangeCurrentMoneyEvent.AddListener(ChangeMoneyText);
        }
        private void OnDisable()
        {
            walletManagerScriptableObject.ChangeCurrentMoneyEvent.RemoveListener(ChangeMoneyText);
        }

        private void ChangeMoneyText(int newAmount)
        {
            moneyText.text = newAmount.ToString();
        }
    }
}