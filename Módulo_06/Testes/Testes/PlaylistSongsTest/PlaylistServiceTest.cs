using Classes.PlaylistSongs;
using NSubstitute;

namespace Testes.PlaylistSongsTest
{
    public class PlaylistServiceTest
    {
        private readonly IPlaylistValidationService _mockPlaylistValidationService;
        private PlaylistService _sut;

        public PlaylistServiceTest()
        {
            _mockPlaylistValidationService = Substitute.For<IPlaylistValidationService>();
            _sut = new(_mockPlaylistValidationService);
        }
        [Fact]
        public void AddSongToPlaylist_MusicaValida_RetornaTrue()
        {
            Playlist playlist = new Playlist { Songs = new List<Song>(), MaxSongs = 5 };

            _mockPlaylistValidationService.CanAddSongToPlaylist(playlist, Arg.Any<Song>())
                .Returns(true);

            bool resultado = _sut.AddSongToPlaylist(playlist, new Song { Title = "Oi Jesus", Artist = "Isadora Pompeo" });

            Assert.True(resultado);
        }
        [Fact]
        public void AddSongToPlaylist_MusicaInvalida_RetornaFalse()
        {
            Playlist playlist = new() { Songs = new List<Song>(), MaxSongs = 5 };

            _mockPlaylistValidationService.CanAddSongToPlaylist(playlist, Arg.Any<Song>()).Returns(false);

            bool resultado = _sut.AddSongToPlaylist(playlist, new Song { Title = "Oi Jesus", Artist = "Isadora Pompeo" });

            Assert.False(resultado);
        }
        [Fact]
        public void AddSongsToPlaylist_MusicasValidas_AdicionaNaPlaylist()
        {
            Playlist playlist = new Playlist { Songs = new List<Song>(), MaxSongs = 5 };
       
            List<Song> songs = new List<Song>()
            {
               new Song { Title = "Oi Jesus", Artist = "Isadora Pompeo" },
               new Song { Title = "Bondade de Deus", Artist = "Isaías Saad" },
            };

            _mockPlaylistValidationService.CanAddSongToPlaylist(playlist, Arg.Any<Song>()).Returns(true);

            _sut.AddSongsToPlaylist(playlist, songs);

            Assert.Equal(2, playlist.Songs.Count);
        }
    }
}