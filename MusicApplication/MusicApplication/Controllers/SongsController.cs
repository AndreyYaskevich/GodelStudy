using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MusicApplication.Models;

namespace MusicApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SongsController : Controller
    {
        private readonly IGenericRepository<Song> _repository;
        public SongsController(IGenericRepository<Song> context)
        {
            _repository = context;
        }

        [HttpGet]
        public IEnumerable<Song> Get() => _repository.GetAll();

        [HttpGet]
        [Route("{id}")]
        public Song Get(int id) => _repository.GetById(id);

        [HttpPost]
        [Route("")]
        public void AddAlbum([FromBody] Song song) => _repository.Insert(song);

        [HttpPut]
        public void Update(Song song)
        {
            var editModel = _repository.GetById(song.Id);
            editModel.Name = song.Name;
            editModel.Author = song.Author;
            _repository.Update(editModel);
        }

        [HttpDelete]
        [Route("{id}")]
        public void Delete(int id) => _repository.Delete(id);
    }
}
