﻿using Football.Core;
using Services;
using UI;
using UnityEngine;
using UnityEngine.UI;

namespace Football.UI
{
    public class NetworkConnectingUI : View
    {
        [SerializeField] private Button _hostBtn;
        [SerializeField] private Button _clientBtn;

        private void Awake()
        {
            _hostBtn.onClick.AddListener(OnHostBtnClicked);
            _clientBtn.onClick.AddListener(OnClientBtnClicked);
        }

        private void OnDestroy()
        {
            _hostBtn.onClick.RemoveListener(OnHostBtnClicked);
            _clientBtn.onClick.RemoveListener(OnClientBtnClicked);
        }

        private void OnHostBtnClicked()
        {
            Engine.GetService<NetworkService>().NetworkManager.StartHost();
        }

        private void OnClientBtnClicked()
        {
            Engine.GetService<NetworkService>().NetworkManager.StartClient();
        }
    }
}