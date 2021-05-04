using App.DatabaseLocal.Models;
using App.Models;
using App.UCs;
using AxWMPLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Common
{
    public static class Constants
    {

        public static readonly string ROOT_PATH = "../../";
        public static readonly string SEPERATE_CHAR = "CS511";

        public static readonly string DOMAIN = "https://localhost:44309/"; 
        public static readonly string SAY_HELLO = DOMAIN + "Api/MusicAPIController/SayHello";
        public static readonly string GET_CATEGORIES = DOMAIN + "Api/MusicAPIController/GetCategories";
        public static readonly string GET_SONGS = DOMAIN + "Api/MusicAPIController/GetSongs";
        public static readonly string CREATE_SONG = DOMAIN + "Api/MusicAPIController/Create";
        public static readonly string UPDATE_SONG = DOMAIN + "Api/MusicAPIController/Update";
        public static readonly string SAVE_FILES_SONG = DOMAIN + "Api/MusicAPIController/UploadFile"; 



        /// <summary>
        /// Color
        /// </summary>
        public static readonly Color MEMU_LEFT_BACKGROUND = Color.FromArgb(35, 27, 46); // fMain
        public static readonly Color FOOTER_BACKGROUND = Color.FromArgb(18, 12, 28); // fMain
        public static readonly Color MAIN_CONTENT_BACKGROUND = Color.FromArgb(23, 15, 35); // fMain
        public static readonly Color ACTIVE_BUTTON_BG_COLOR = Color.FromArgb(58, 51, 68); // fMain
        public static readonly Color BORDER_MENU_LEFT_COLOR = Color.FromArgb(249, 88, 155); // fMain 


        public static readonly Color COLOR_FIRST = Color.FromArgb(74, 144, 226); // fSongList
        public static readonly Color COLOR_SECONDE = Color.FromArgb(80, 227, 194); // fSongList
        public static readonly Color COLOR_THRID = Color.FromArgb(227, 80, 80); // fSongList
        public static readonly Color COLOR_DEFAULT = Color.FromArgb(192, 190, 195); // fSongList

        public static bool errorDuration = false;


        public static int CURRENT_ROTATION = 0;
        public static bool IsPlaulistReady = false;
        public static bool IsPersonalReady = false;
        public static bool isPriority = false;
        public static bool isDelete = false;

        public static fLayout MainForm;
        public static AxWindowsMediaPlayer MainMedia;

        public static PlaylistItemUC CurrentPlaylistItemUC;
        public static PlaylistItemPUC CurrentPlaylistItemPUC;

        public static fPlaylist CurrentPlaylist;
        public static fPersonal CurrentPersonal;
        public static fManager CurrentManager;

        public static CURRENT_PAGE CURRENT_PAGE;
        public static CURRENT_PLAYLIST CURRENT_PLAYLIST;
        public static CURRENT_SONG_PLAYING CURRENT_SONG_PLAYING;

        public static bool IsReapeat = false;


        public static List<SongPersonal> SongPersonals;

        //public static List<Song> APISongs = null;
        //public static List<SongCategory> APISongCategories = null;

    }

    public enum CURRENT_PAGE
    {
        PERSONAL,
        PLAYLIST,
        MANAGER
    }

    public enum CURRENT_PLAYLIST
    {
        PERSONA_PLAYLISTL,
        PLAYLIST_PLAYLIST,
        MANAGER_PLAYLIST
    }

    public enum CURRENT_SONG_PLAYING
    {
        PERSONA_SONG_PLAYING,
        PLAYLIST_SONG_PLAYING,
        MANAGER_SONG_PLAYING
    }
}
