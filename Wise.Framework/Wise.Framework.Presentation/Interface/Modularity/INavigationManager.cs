﻿using System;
using Wise.Framework.Presentation.ViewModel;

namespace Wise.Framework.Presentation.Interface.Modularity
{
    public interface INavigationManager : IDisposable
    {
        void RegisterViewModelForNavigation(ViewModelBase viewModel);
        void RegisterTypeForNavigation<T>();
        void RegisterTypeForNavigation(Type viewModelType);
    }
}