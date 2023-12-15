namespace Classes.PlaylistSongs
{
    public interface IPlaylistValidationService
    {
        bool CanAddSongToPlaylist(Playlist playlist, Song song);
    }
}
