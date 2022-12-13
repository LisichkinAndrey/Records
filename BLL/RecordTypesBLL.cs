using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#nullable enable

namespace records
{
    [System.ComponentModel.DataObject]
    public class RecordTypesBLL
    {
        private RecordTypesDAL DAL = new RecordTypesDAL();

        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Select, true)]

        public void AddRecordType(string name, string description, float payment)
        {
            DAL.AddRecordType(new RecordType
            {
                Number = DAL.GetLastNumber() + 1,
                Name = name,
                Description = description,
                PaymentPerHour = payment
            });
        }

        public List<RecordType>? GetAllRecordTypes()
        {
            return DAL.GetAllRecordTypes();
        }

        public RecordType? GetRecordTypeByNumber(int recordTypeNumber)
        {
            return DAL.GetRecordTypeByNumber(recordTypeNumber);
        }

        public List<RecordType>? GetRecordTypesByName(string name)
        {
            return DAL.GetRecordTypesByName(name);
        }

        public void UpdateRecordTypeName(int recordTypeNumber, string newName)
        {
            DAL.UpdateRecordTypeName(recordTypeNumber, newName);
        }

        public void RemoveRecordType(int recordTypeNumber)
        {
            DAL.RemoveRecordType(recordTypeNumber);
        }
    }
}
