//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//namespace NotificationProjectBackendWCF
//{
//    public class NotificationService : INotificationService
//    {
//        public bool InsertAnnouncement(Announcement obj)
//        {
//            announcementList.Add(obj);
//            return true;
//        }

//        public List<Announcement> ListAnnouncement()
//        {
//            return announcementList;
//        }

//        public bool DeleteAnnouncement(int Cid)
//        {
//            var item = announcementList.First(x => x.ID == Cid);

//            announcementList.Remove(item);
//            return true;
//        }

//        public bool UpdateAnnouncement(Announcement obj)
//        {
//            var list = announcementList;
//            announcementList.Where(p => p.ID ==
//            obj.ID).UpdateAnnouncement(p => p.Body = obj.Body);
//            return true;
//        }

//        public static List<Announcement> announcementList = new List<Announcement>()
//         {
//        new Announcement {ID = 1, Body="Sujeet", StartDate= new DateTime(2022,05,13), EndDate= new DateTime(2022,05,15), Severity = 2, LastUpdateDate= new DateTime(2022,05,15)},
//        new Announcement {ID = 2, Body="ornvulsd", StartDate= new DateTime(2022,05,22), EndDate= new DateTime(2022,05,30), Severity = 2, LastUpdateDate= new DateTime(2022,05,15)},
//        new Announcement {ID = 3, Body="pojefohu ıruewvg", StartDate= new DateTime(2022,05,28), EndDate= new DateTime(2022,05,31), Severity = 2, LastUpdateDate= new DateTime(2022,05,15)},
//         };
//    }


//    public static class LinqUpdates
//    {
//        public static void UpdateAnnouncement<T>(this IEnumerable<T> source, Action<T> action)
//        {
//            foreach (var item in source)
//                action(item);
//        }
//    }

//}