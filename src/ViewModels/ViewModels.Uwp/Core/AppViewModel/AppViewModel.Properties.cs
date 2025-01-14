﻿// Copyright (c) Richasy. All rights reserved.

using System.Reactive;
using Bili.Lib.Interfaces;
using Bili.Toolkit.Interfaces;
using Bili.ViewModels.Interfaces.Core;
using Microsoft.Toolkit.Uwp.Connectivity;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Windows.UI.Core;

namespace Bili.ViewModels.Uwp.Core
{
    /// <summary>
    /// <see cref="AppViewModel"/>的属性集.
    /// </summary>
    public sealed partial class AppViewModel
    {
        private readonly IResourceToolkit _resourceToolkit;
        private readonly ISettingsToolkit _settingsToolkit;
        private readonly IAppToolkit _appToolkit;
        private readonly IUpdateProvider _updateProvider;
        private readonly ICallerViewModel _callerViewModel;
        private readonly INavigationViewModel _navigationViewModel;
        private readonly NetworkHelper _networkHelper;
        private readonly CoreDispatcher _dispatcher;

        private bool? _isWide;

        /// <summary>
        /// 检查应用更新命令.
        /// </summary>
        public ReactiveCommand<Unit, Unit> CheckUpdateCommand { get; }

        /// <summary>
        /// 检查新动态通知的命令.
        /// </summary>
        public ReactiveCommand<Unit, Unit> CheckNewDynamicRegistrationCommand { get; }

        /// <summary>
        /// 导航面板是否已展开.
        /// </summary>
        [Reactive]
        public bool IsNavigatePaneOpen { get; set; }

        /// <summary>
        /// 页面标题文本.
        /// </summary>
        [Reactive]
        public string HeaderText { get; set; }

        /// <summary>
        /// 是否在Xbox上运行.
        /// </summary>
        [Reactive]
        public bool IsXbox { get; set; }

        /// <summary>
        /// 页面横向边距.
        /// </summary>
        [Reactive]
        public double PageHorizontalPadding { get; set; }

        /// <summary>
        /// 页面顶部边距.
        /// </summary>
        [Reactive]
        public double PageTopPadding { get; set; }

        /// <summary>
        /// 是否显示标题栏.
        /// </summary>
        [Reactive]
        public bool IsShowTitleBar { get; set; }

        /// <summary>
        /// 是否显示菜单按钮.
        /// </summary>
        [Reactive]
        public bool IsShowMenuButton { get; set; }

        /// <summary>
        /// 网络是否可用.
        /// </summary>
        [Reactive]
        public bool IsNetworkAvaliable { get; set; }

        /// <summary>
        /// 是否为繁体中文环境.
        /// </summary>
        [Reactive]
        public bool IsTraditionalChinese { get; set; }
    }
}
