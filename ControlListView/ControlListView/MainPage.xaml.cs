using ControlListView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ControlListView
{
    public partial class MainPage : ContentPage
    {
        public List<String> Data { get; set; }
        public List<Song> SongList { get; set; }
        public MainPage()
        {
            InitializeComponent();
            this.SongList = new List<Song>();
            Song song = new Song()
            {
                Image = "https://i.ytimg.com/vi/TeILJ_M77wg/hqdefault.jpg",
                Title = "Historias de amor",
                Artist = "OBK"
            };
            this.SongList.Add(song);
            song = new Song()
            {
                Image = "https://images.shazam.com/coverart/t55956251-b1329085532_s400.jpg",
                Title = "Dame veneno",
                Artist = "Los Chunguitos"
            };
            this.SongList.Add(song);
            song = new Song()
            {
                Image = " http://img.desmotivaciones.es/201102/Melody7.jpg",
                Title = "El baile del gorila",
                Artist = "Melody"
            };
            this.SongList.Add(song);

            //Data = new List<String>();
            //Data.Add("H");
            //Data.Add("E");
            //Data.Add("L");
            //Data.Add("L");
            //Data.Add("O");
            //Data.Add(" ");
            //Data.Add("W");
            //Data.Add("O");
            //Data.Add("R");
            //Data.Add("L");
            //Data.Add("D");
            //Data.Add("¡");
            this.Songs.ItemsSource = SongList;
        }
    }
}
