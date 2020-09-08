using Microsoft.AspNetCore.Mvc;
using MusicApplication.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Threading.Tasks;

namespace MusicApplication
{
    public interface IGenericRepository<T> where T: class
    {
        /*
        
        IEnumerable<Album> GetAlbums();
        Album GetAlbumById(int albumId);
        void Insert(Album album);
        void Delete(int id);
        void Update(Album album);
        void Save();
        */
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Insert(T entity);
        void Delete(int id);
        void Update(T entity);
        void Save();
        int GetCountOfSongs();
    }
}
