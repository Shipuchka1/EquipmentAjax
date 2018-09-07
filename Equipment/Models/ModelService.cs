using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Equipment.Models
{
    public class ModelService
    {
        public static Model1 db = new Model1();
        public static newEquipment GetEquipmentById(string id)
        {
            int idEq = Int32.Parse(id);
            newEquipment equipment = db.newEquipments.FirstOrDefault(f => f.intEquipmentID == idEq);
            equipment.TrackMeters = db.TrackMeters.Where(w => w.intEquipmentID == equipment.intEquipmentID).ToList();
            return equipment;
        }

        public static List<TrackServiceHistory> GetTrackServiceHistoriesForEquipment(string id)
        {
            int idEq = Int32.Parse(id);
            List<TrackServiceHistory> trackServiceHistories = db.TrackServiceHistories.Where(w => w.intEquipmentID == idEq).ToList();
            return trackServiceHistories;
        }

        public static List<TrackServiceHistoryPart> GetTrackServiceHistoryPartsById(string id)
        {
            int idT = Int32.Parse(id);
            List<TrackServiceHistoryPart> trackServiceHistoryParts = db.TrackServiceHistoryParts.Where(w => w.intServiceHistoryId == idT).ToList();
            return trackServiceHistoryParts;
        }

        public static List<TrackServiceHistoryProvider> GetTrackServiceHistoryProvidersForTrackServiceHistory(string id)
        {
            List<TrackServiceHistory> trackServiceHistories = GetTrackServiceHistoriesForEquipment(id);
            List<TrackServiceHistoryProvider> trackServiceHistoriesProviders = new List<TrackServiceHistoryProvider>();
            foreach (TrackServiceHistory item in trackServiceHistories)
            {
                trackServiceHistoriesProviders.AddRange(item.TrackServiceHistoryProviders);
            }

            return trackServiceHistoriesProviders;
        }
    }
}