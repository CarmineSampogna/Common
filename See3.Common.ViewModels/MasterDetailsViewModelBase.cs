using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace See3.Common.ViewModels
{
    public abstract class MasterDetailsViewModelBase<TDataType> : ViewModelBase where TDataType : class
    {
        private TDataType _selectedItem;
        public TDataType SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                if (value != _selectedItem)
                {
                    _selectedItem = value;
                    SelectedItemChanged?.Invoke(this, EventArgs.Empty);
                    Debug.WriteLine("SelectedItem changed");
                    OnPropertyChanged("SelectedItem");
                }
            }
        }


        private ObservableCollection<TDataType> _items;
        public ObservableCollection<TDataType> Items
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

        private DelegateCommand _createNewItemCommand;
        public DelegateCommand CreateNewItemCommand
        {           
            get { return _createNewItemCommand; }
            set
            {
                if (value != _createNewItemCommand)
                {
                    _createNewItemCommand = value;
                    OnPropertyChanged("CreateNewItemCommand");
                }
            }
        }

        public event EventHandler SelectedItemChanged;

        /// <summary>
        /// Override if using the CreateNewItemCommand.
        /// </summary>
        protected virtual void ExecuteCreateNewItem()
        { }

        /// <summary>
        /// Optional. Override to enable / disable CreateNewItemCommand. Call CreateNewItemCommand.RaiseCanExecuteChange to re-evaluate.
        /// </summary>
        /// <returns></returns>
        protected virtual bool CanExecuteCreateNewItem()
        {
            return true;
        }

    }
}
