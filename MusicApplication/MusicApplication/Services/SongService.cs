using MusicApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace MusicApplication.Services
{
    public class SongService : ISongService
    {
        private readonly IGenericRepository<Song> _repository;
        public SongService(IGenericRepository<Song> repository)
        {
            _repository = repository;
        }
        public void AddSongsWithPrefix(List<Song> songs)
        {
            var tmp = _repository.GetCountOfSongs();
            foreach (var song in songs)
            {
                
                song.Name = $"{_repository.GetCountOfSongs()+1}.{song.Name}";
                _repository.Insert(song);
                
            }
        }
    }
}
