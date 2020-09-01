using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Diagnostics;
using MusicApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicApplication.Controllers
{
    public class HomeController : Controller
    {
        ApplicationContext db;
        public HomeController(ApplicationContext context)
        {
            db = context;
            if (!context.Songs.Any())
            {
                context.AddRange(
                    new Song
                    {
                        Name = "Immortals",
                        Author = "Fall Out Boys"
                    },
                    new Song 
                    {
                        Name = "Peremen",
                        Author = "Tsoy"
                    });

                context.SaveChanges();
            }
        }

        public Song GetSong(int id)
        {
            Song song = db.Songs.FirstOrDefault(x => x.Id == id);
            return song;
        }

        public void AddSong(string name, string author)
        {
            db.Add(
                new Song
                {
                    Name = name,
                    Author = author
                }
                );
            db.SaveChanges();
        }

        public void DeleteSong(int id)
        {
            Song song = db.Songs.FirstOrDefault(x => x.Id == id);
            if (song != null)
            {
                db.Songs.Remove(song);
                db.SaveChanges();
            }
        }

    }
}
