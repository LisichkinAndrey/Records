using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using records;

#nullable enable

namespace records.Controllers
{
    [ApiController]
    [Route("recordtypes")]
    [ApiExplorerSettings(GroupName = "recordtypes")]
    public class RecordTypesController : ControllerBase
    {

        RecordTypesBLL BLL = new RecordTypesBLL();

        [HttpPut]
        [Route("add")]
        public void AddRecordType(string name, string description, float payment)
        {
            BLL.AddRecordType(name, description, payment);
        }

        [HttpGet]
        [Route("get_all")]
        public List<RecordType>? GetAllRecordTypes()
        {
            return BLL.GetAllRecordTypes();
        }

        [HttpGet]
        [Route("get_by_num")]
        public RecordType? GetRecordTypeByNumber(int recordTypeNumber)
        {
            return BLL.GetRecordTypeByNumber(recordTypeNumber);
        }

        [HttpGet]
        [Route("get_by_name")]
        public List<RecordType>? GetRecordTypesByName(string name)
        {
            return BLL.GetRecordTypesByName(name);
        }

        [HttpPatch]
        [Route("patch_name")]
        public void UpdateRecordTypeName(int recordTypeNumber, string newName)
        {
            BLL.UpdateRecordTypeName(recordTypeNumber, newName);
        }

        [HttpDelete]
        [Route("delete_by_num")]
        public void RemoveRecordType(int recordTypeNumber)
        {
            BLL.RemoveRecordType(recordTypeNumber);
        }

    }
}
