using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMusic.Models;

namespace WebMusic.Controllers
{
    public class TrackController : Controller
    {

        MusicEntities db = new MusicEntities();

        // GET: Track
        public ActionResult Index(int id)
        {
            return View(id);
        }

        public PartialViewResult Detail_Track(int id)
        {

            List<string> temp1 = db.TRACK_ARTIST.Where(p => p.ID_TRACK == id).Select(p => p.NAME_ARTIST).ToList();
            List<string> temp2 = db.TRACK_ARTIST.Where(p => p.ID_TRACK == id).Select(p => p.NAME_LABEL).ToList();

            ViewBag.Artist = temp1;
            ViewBag.Label = temp2;

            return PartialView(db.TRACKs.Where(p => p.ID == id).SingleOrDefault());
        }

    }
}