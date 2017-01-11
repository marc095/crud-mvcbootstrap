using mvc5bootstrap.Concrete;
using mvc5bootstrap.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace mvc5bootstrap.Controllers
{
    public class AdminController : Controller
    {
        EfContext context = new EfContext();
        // GET: Admin
        public ActionResult Index()
        {
            List<Team> teams = context.Teams.ToList();
            ViewBag.Teams = new SelectList(teams, "TeamId", "Name");
            List<PlayerViewModel> list = context.Players.Select(x => new PlayerViewModel
            { Name = x.Name, SurName = x.SurName, TeamID = x.TeamID, Age = x.Age, PlayerID = x.PLayerID }).ToList();
            ViewBag.Players = list;
            return View();
        }
        [HttpPost]
        public ActionResult Index(PlayerViewModel playerVM)
        {
            List<Team> teams = context.Teams.ToList();
            ViewBag.Teams = new SelectList(teams, "TeamId", "Name");
            List<PlayerViewModel> list = context.Players.Select(x => new PlayerViewModel
            { Name = x.Name, SurName = x.SurName, TeamID = x.TeamID, Age = x.Age, PlayerID = x.PLayerID }).ToList();
            ViewBag.Players = list;
            if (playerVM.PlayerID > 0)
            {
                Player player = Mappers.Mapping.Map(playerVM);
                context.SaveChanges();
            }
            else
            {
                Player player = Mappers.Mapping.Map(playerVM);
                context.Players.Add(player);
                context.SaveChanges();
            }
            return View(playerVM);
        }
        public ActionResult Edit(int playerId)
        {
            List<Team> teams = context.Teams.ToList();
            ViewBag.Teams = new SelectList(teams, "TeamId", "Name");
            PlayerViewModel playerVM = null;
            if (playerId > 0)
            {
                Player player = context.Players.FirstOrDefault(x => x.PLayerID == playerId);
                playerVM = Mappers.Mapping.Map(player);
            }
            return PartialView("~/Views/Admin/Partial.cshtml", playerVM);
        }
        public ActionResult Delete(int id)
        {
            Player player = context.Players.Find(id);
            return PartialView("~/Views/Admin/Delete.cshtml", player);
        }
        [HttpPost]
        public ActionResult Delete(Player player)
        {
            if (player != null)
            {
                Player p1 = context.Players.Find(player.PLayerID);
                context.Players.Remove(p1);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}