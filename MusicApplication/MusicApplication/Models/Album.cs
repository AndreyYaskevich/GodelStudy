using MusicApplication.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicApplication.Models
{
    public class Album : IDataObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SongId { get; set; }
        public Song Song { get; set; }
    }
}
