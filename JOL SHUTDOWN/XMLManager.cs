using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace JOL_SHUTDOWN
{
    class XMLManager
    {
        static string xmlPath = "Schedules.xml";
        public static void Prepare_and_Add_SchedulesXML(Schedule[] schedule)
        {
            //Schedule(int id, ScheduleActions action, DateTime date, TimeSpan time, ScheduleRepeat repeat, int status)
            using (XmlWriter writer = XmlWriter.Create("Schedules.xml"))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Schedules");

                foreach (Schedule sched in schedule)
                {
                    writer.WriteStartElement("Schedule");

                    writer.WriteAttributeString("id", sched.id.ToString());   // <-- These are new
                    writer.WriteElementString("action", sched.action.ToString());
                    writer.WriteElementString("date", sched.date.ToShortDateString());
                    writer.WriteElementString("time", sched.time.ToString());
                    writer.WriteElementString("repeat", sched.repeat.ToString());
                    writer.WriteElementString("status", sched.status.ToString());

                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }

        public static void PrepareSchedulesXML()
        {
            //Schedule(int id, ScheduleActions action, DateTime date, TimeSpan time, ScheduleRepeat repeat, int status)
            using (XmlWriter writer = XmlWriter.Create("Schedules.xml"))
            {
                writer.WriteStartDocument();
                writer.WriteComment("JOL SHUTDOWN MANAGER");
                writer.WriteComment("This XML file stores ");
                writer.WriteStartElement("Schedules");



                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }

        public static void AddSchedule(Schedule sched)
        {
            
            XDocument doc = XDocument.Load(xmlPath);
            XElement root = new XElement("Schedule");
            root.Add(new XAttribute("id", sched.id.ToString()));
            root.Add(new XElement("action", sched.action.ToString()));
            root.Add(new XElement("date", sched.date.ToString()));
            root.Add(new XElement("time", sched.time.ToString()));
            root.Add(new XElement("status", sched.status.ToString()));
            doc.Element("Schedules").Add(root);
            doc.Save(xmlPath);
        }

        public static void RemoveSchedule(Schedule sched)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlPath);

            // find a node - here the one with name='abc'
            XmlNode node = doc.SelectSingleNode("/Schedules/Schedule[@id='"+sched.id+"']");
            
            if (node != null)
            {
                XmlNode parent = node.ParentNode;
                parent.RemoveChild(node);
                string newXML = doc.OuterXml;
                
                doc.Save(xmlPath);
            }
        }
    }
}
