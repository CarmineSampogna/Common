using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using See3.Common.Models.Interfaces;
using See3.Common.ViewModels;

namespace INfur.Mocks.UWP.ViewModels
{
    /// <summary>
    /// Abstract ViewModel for displaying a collection of items with a selected item.
    /// </summary>
    /// <typeparam name="TViewModel">The ViewModel type that represents the underlying model type</typeparam>
    /// <typeparam name="T">The underlying model type</typeparam>
    public abstract class EntityCollectionViewModel<TViewModel, T, TRepository> : ViewModelBase
        where T : IEntity, new()
        where TViewModel : ViewModelBase<T>
        where TRepository : IRepository<T, Guid>
    {
        protected TRepository Repository { get; }

        private bool _noData;
        public bool NoData
        {
            get { return _noData; }
            set
            {
                if (value != _noData)
                {
                    _noData = value;
                    OnPropertyChanged("NoData");
                }
            }
        }

        private string _noDataReason;
        public string NoDataReason
        {
            get { return _noDataReason; }
            set
            {
                if (value != _noDataReason)
                {
                    _noDataReason = value;
                    OnPropertyChanged("NoDataReason");
                }
            }
        }

        private string _noDataDetails;
        public string NoDataDetails
        {
            get { return _noDataDetails; }
            set
            {
                if (value != _noDataDetails)
                {
                    _noDataDetails = value;
                    OnPropertyChanged("NoDataDetails");
                }
            }
        }

        private ObservableCollection<TViewModel> _items;
        public ObservableCollection<TViewModel> Items
        {
            get { return _items; }
            set
            {
                if (value != _items)
                {
                    _items = value;
                    OnPropertyChanged("Items");
                }
            }
        }

        private TViewModel _selectedItem;
        public TViewModel SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                if (value != _selectedItem)
                {
                    _selectedItem = value;
                    OnPropertyChanged("SelectedItem");
                    SelectedItemChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        public EntityCollectionViewModel(TRepository repository)
        {
            if (repository == null) throw new ArgumentNullException(nameof(repository));
            Repository = repository;
        }

        public event EventHandler SelectedItemChanged;

        public override abstract Task RefreshAsync();
    }
}
