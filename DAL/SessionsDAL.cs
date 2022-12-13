using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#nullable enable

namespace records
{
    public class SessionsDAL
    {
        ApplicationContext db = new ApplicationContext();

        public void AddSession(Session session)
        {
            db.Sessions.Add(session);
        }

        public int GetLastNumber()
        {
            int? id = db.Sessions.Max(r => r.Number);
            if (id == null) { return 1; }
            else { return (int)id; }
        }

        public List<Session>? GetAllSessions()
        {
            List<Session>? sessions = db.Sessions.ToList();
            return sessions;
        }

        public Session? GetSessionByNumber(int sessionNumber)
        {
            Session? session = (from r in db.Sessions where r.Number == sessionNumber select r).FirstOrDefault();
            return session;
        }

        public List<Session>? GetSessionsByCustomerNumber(int customerNumber)
        {
            List<Session>? session = (from r in db.Sessions where r.CustomerNumber == customerNumber select r).ToList();
            return session;
        }

        public List<Session>? GetSessionsByEmployeeNumber(int employeeNumber)
        {
            List<Session>? session = (from r in db.Sessions where r.EmployeeNumber == employeeNumber select r).ToList();
            return session;
        }

        public void UpdateSessionCustomerNumber(int sessionNumber, int customerNumber)
        {
            Session? session = (from r in db.Sessions where r.Number == sessionNumber select r).FirstOrDefault();
            if (session != null)
            {
                session.CustomerNumber = customerNumber;
                db.SaveChanges();
            }
        }

        public void UpdateSessionEmployeeNumber(int sessionNumber, int employeeNumber)
        {
            Session? session = (from r in db.Sessions where r.Number == sessionNumber select r).FirstOrDefault();
            if (session != null)
            {
                session.EmployeeNumber = employeeNumber;
                db.SaveChanges();
            }
        }

        public void RemoveSession(int sessionNumber)
        {
            Session? session = (from r in db.Sessions where r.Number == sessionNumber select r).FirstOrDefault();
            if (session != null)
            {
                db.Sessions.Remove(session);
            }
        }
    }
}
