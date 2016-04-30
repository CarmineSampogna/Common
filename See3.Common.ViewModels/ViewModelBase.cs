using System;
using System.ComponentModel;
using System.Threading.Tasks;

namespace See3.Common.ViewModels
{
    public abstract class ViewModelBase : INotifyPropertyChanged, IDisposable
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
        public abstract Task RefreshAsync();

        public abstract Task RefreshAsync<TParameter>(TParameter parameter);

        /// <summary>
        /// Should be called once, when ViewModel is no longer needed.
        /// </summary>
        public abstract void Dispose();


        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }

    public abstract class ViewModelBase<TModelType> : ViewModelBase where TModelType : new() 
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
    }
}
