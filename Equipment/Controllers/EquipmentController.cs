using Equipment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Equipment.Controllers
{
    public class EquipmentController : Controller
    {
        Model1 db = new Model1();

        // GET: Equipment
        public ActionResult Index()

        {
            return View(db.newEquipments.ToList());
        }

        [HttpPost]
        public ActionResult EquipmentDetails(string id)
        {
            newEquipment equipment = ModelService.GetEquipmentById(id);
            return PartialView(equipment);
        }

        [HttpPost]
        public PartialViewResult GetTrackMeters(string id)
        {
            newEquipment equipment = ModelService.GetEquipmentById(id);
            return PartialView(equipment);
        }

        [HttpPost]
        public PartialViewResult GetTrackServiceHistory(string id)
        {
            List<TrackServiceHistory> trackServiceHistories = ModelService.GetTrackServiceHistoriesForEquipment(id);
            return PartialView(trackServiceHistories);
        }

        [HttpPost]
        public PartialViewResult GetServiceDetail(string id)
        {
            return PartialView(ModelService.GetTrackServiceHistoryPartsById(id));
        }

        [HttpPost]
        public PartialViewResult GetTrackServiceHistoryProvider(string id)
        {
            return PartialView(ModelService.GetTrackServiceHistoryProvidersForTrackServiceHistory(id));
        }

        [HttpPost]
        public PartialViewResult Diagram(string id)
        {
            ViewBag.IdEq = id;
            List<TrackServiceHistory> trackServiceHistories = ModelService.GetTrackServiceHistoriesForEquipment(id);
            Dictionary<string, int> dateDic = new Dictionary<string, int>();
            foreach (TrackServiceHistory item in trackServiceHistories)
            {
                if (dateDic.ContainsKey(item.dRepairDate.ToString("MMMM, yyyy")))
                    dateDic[item.dRepairDate.ToString("MMMM, yyyy")]++;
                else
                    dateDic.Add(item.dRepairDate.ToString("MMMM, yyyy"), 1);
            }
            return PartialView(dateDic);
        }
    }
}