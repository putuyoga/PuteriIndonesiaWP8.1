using Newtonsoft.Json;
using PuteriIndonesia.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace PuteriIndonesia.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// untuk menampung items Puteri Indonesia
        /// </summary>
        private List<Puteri> _listPuteri;

        /// <summary>
        /// Memberikan akses items Puteri Indonesia
        /// </summary>
        public List<Puteri> ListPuteri
        {
            get { return _listPuteri; }
            set
            {
                if(_listPuteri != value)
                {
                    _listPuteri = value;
                    NotifyPropertyChanged("ListPuteri");
                }
            }
        }

        /// <summary>
        /// Mengambil items Puteri Indonesia dari local dari deserialize
        /// </summary>
        public async void GetData()
        {
            Uri dataUri = new Uri("ms-appx:///Assets/DataPuteri.json");

            StorageFile file = await StorageFile.GetFileFromApplicationUriAsync(dataUri);
            string jsonText = await FileIO.ReadTextAsync(file);
            ListPuteri = JsonConvert.DeserializeObject<List<Puteri>>(jsonText);
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
