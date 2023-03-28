using System;
using System.Collections.Generic;
using System.Text;
using CV19.ViewModel.Base;

namespace CV19.ViewModels
{
    internal class MainWindowsViewMode : VIewModel
    {
        #region Заголовок окна
        private string _Title = "Анализ статистики CV19";
        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }
        #endregion
    }
}