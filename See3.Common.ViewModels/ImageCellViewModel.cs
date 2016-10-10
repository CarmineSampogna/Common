using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace See3.Common.ViewModels
{
    public class ImageCellViewModel : ViewModelBase
    {
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
        

        public override async Task InitializeAsync()
        {
            return;
        }
    }
}
