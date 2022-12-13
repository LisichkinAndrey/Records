using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#nullable enable

namespace records
{
    public class RecordTypesDAL
    {
        ApplicationContext db = new ApplicationContext();

        public void AddRecordType(RecordType recordType)
        {
            db.RecordTypes.Add(recordType);
        }

        public int GetLastNumber()
        {
            int? id = db.RecordTypes.Max(r => r.Number);
            if (id == null) { return 1; }
            else { return (int)id; }
        }

        public List<RecordType>? GetAllRecordTypes()
        {
            List<RecordType>? recordTypes = db.RecordTypes.ToList();
            return recordTypes;
        }

        public RecordType? GetRecordTypeByNumber(int recordTypeNumber)
        {
            RecordType? recordType = (from r in db.RecordTypes where r.Number == recordTypeNumber select r).FirstOrDefault();
            return recordType;
        }

        public List<RecordType>? GetRecordTypesByName(string name)
        {
            List<RecordType>? recordTypes = (from r in db.RecordTypes where r.Name.Contains(name) select r).ToList();
            return recordTypes;
        }

        public void UpdateRecordTypeName(int recordTypeNumber, string newName)
        {
            RecordType? recordType = (from r in db.RecordTypes where r.Number == recordTypeNumber select r).FirstOrDefault();
            if (recordType != null)
            {
                recordType.Name = newName;
                db.SaveChanges();
            }
        }

        public void RemoveRecordType(int recordTypeNumber)
        {
            RecordType? recordType = (from r in db.RecordTypes where r.Number == recordTypeNumber select r).FirstOrDefault();
            if (recordType != null)
            {
                db.RecordTypes.Remove(recordType);
            }
        }
    }
}
