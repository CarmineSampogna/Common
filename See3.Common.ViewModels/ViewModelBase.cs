using System;
using System.ComponentModel;
using System.Threading.Tasks;

namespace See3.Common.ViewModels
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        /// <summary>
        /// Should be called once, when the ViewModel is first needed.
        /// </summary>
        /// <returns></returns>
        public abstract Task InitializeAsync();


        /// <summary>
        /// Logic to refresh the state of the ViewModel. Should be called when app resumes.
        /// </summary>
        /// <returns></returns>
        public virtual Task RefreshAsync()
        {
            return Task.Run(() => { });
        }

        public virtual Task RefreshAsync<TParameter>(TParameter parameter)
        {
            return Task.Run(() => { });
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }

    public abstract class ViewModelBase<TModelType> : ViewModelBase where TModelType : new()
    {
        protected TModelType ModelObject { get; set; }

        private string _imageUri;
        public string ImageUri
        {
            get { return _imageUri; }
            set
            {
                if (value != _imageUri)
                {
                    _imageUri = value;
                    OnPropertyChanged("ImageUri");
                }
            }
        }

        private string _primaryText;
        public string PrimaryText
        {
            get { return _primaryText; }
            set
            {
                if (value != _primaryText)
                {
                    _primaryText = value;
                    OnPropertyChanged("PrimaryText");
                }
            }
        }

        private string _secondaryText;
        public string SecondaryText
        {
            get { return _secondaryText; }
            set
            {
                if (value != _secondaryText)
                {
                    _secondaryText = value;
                    OnPropertyChanged("SecondaryText");
                }
            }
        }

        private string _tertiaryText;
        public string TertiaryText
        {
            get { return _tertiaryText; }
            set
            {
                if (value != _tertiaryText)
                {
                    _tertiaryText = value;
                    OnPropertyChanged("TertiaryText");
                }
            }
        }



        protected ViewModelBase()
        {
            ModelObject = new TModelType();
        }

        protected ViewModelBase(TModelType modelObject)
        {
            ModelObject = modelObject;
        }
    }
}
