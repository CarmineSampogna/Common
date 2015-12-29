using System.ComponentModel;

namespace See3.Common.ViewModels
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public abstract class ViewModelBase<TModelType> : INotifyPropertyChanged where TModelType : new() 
    {
        public TModelType ModelObject { get; set; }

        protected ViewModelBase()
        {
            ModelObject = new TModelType();
        }

        protected ViewModelBase(TModelType modelObject)
        {
            ModelObject = modelObject;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
