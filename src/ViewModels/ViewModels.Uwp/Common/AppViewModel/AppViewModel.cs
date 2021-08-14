﻿// Copyright (c) Richasy. All rights reserved.

using Richasy.Bili.Controller.Uwp;
using Richasy.Bili.Locator.Uwp;
using Richasy.Bili.Models.Enums;

namespace Richasy.Bili.ViewModels.Uwp
{
    /// <summary>
    /// 应用ViewModel.
    /// </summary>
    public partial class AppViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppViewModel"/> class.
        /// </summary>
        internal AppViewModel()
        {
            _ = BiliController.Instance;
            IsNavigatePaneOpen = true;
            CurrentMainContentId = PageIds.Recommend;
            ServiceLocator.Instance.LoadService(out _resourceToolkit);
            _displayRequest = new Windows.System.Display.DisplayRequest();
        }

        /// <summary>
        /// 修改当前主内容标识.
        /// </summary>
        /// <param name="pageId">主内容标识.</param>
        public void SetMainContentId(PageIds pageId)
        {
            CurrentMainContentId = pageId;
            IsShowOverlay = false;
        }

        /// <summary>
        /// 修改当前覆盖内容标识.
        /// </summary>
        /// <param name="pageId">覆盖内容标识.</param>
        /// <param name="param">导航参数.</param>
        public void SetOverlayContentId(PageIds pageId, object param = null)
        {
            CurrentOverlayContentId = pageId;
            IsShowOverlay = true;
            RequestOverlayNavigation?.Invoke(this, param);
        }

        /// <summary>
        /// 打开播放器播放视频.
        /// </summary>
        /// <param name="playVM">包含播放信息的视图模型.</param>
        public void OpenPlayer(object playVM)
        {
            RequestPlay?.Invoke(this, playVM);
            IsOpenPlayer = true;
        }

        /// <summary>
        /// 激活显示请求.
        /// </summary>
        public void ActiveDisplayRequest()
        {
            _displayRequest.RequestActive();
        }

        /// <summary>
        /// 释放显示请求.
        /// </summary>
        public void ReleaseDisplayRequest()
        {
            _displayRequest.RequestRelease();
        }
    }
}