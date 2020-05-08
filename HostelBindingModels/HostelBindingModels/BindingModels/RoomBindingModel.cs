using System;
using System.Collections.Generic;
using System.Text;

namespace HostelBusinessLogic.BindingModels
{
    public class RoomBindingModel
    {
        public int? Id { get; set; }
        public int? Number { get; set; }
        public string Status { get; set; }
        public int Capacity { get; set; }
    }
}
