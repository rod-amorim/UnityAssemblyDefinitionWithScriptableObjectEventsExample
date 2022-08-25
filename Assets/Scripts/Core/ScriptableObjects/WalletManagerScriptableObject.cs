using System;
using UnityEngine;
using UnityEngine.Events;

namespace Core.ScriptableObjects
{
    [CreateAssetMenu(fileName = "WalletManagerScriptableObject", menuName = "ScriptableObjects/WalletManager")]
    public class WalletManagerScriptableObject : UnityEngine.ScriptableObject
    {
        [SerializeField] 
        private int currentMoney;

        [NonSerialized] 
        public UnityEvent<int> ChangeCurrentMoneyEvent;

        private void OnEnable()
        {
            ChangeCurrentMoneyEvent ??= new UnityEvent<int>();
        }

        public void AddMoney(int amount)
        {
            currentMoney += amount;
            ChangeCurrentMoneyEvent.Invoke(currentMoney);
        }
        
        public void RemoveMoney(int amount)
        {
            currentMoney -= amount;
            ChangeCurrentMoneyEvent.Invoke(currentMoney);
        }
    }
}