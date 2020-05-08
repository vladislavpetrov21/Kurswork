using System;
using System.Collections.Generic;
using System.Text;

namespace HostelBusinessLogic.BindingModels
{
    public class GuestBindingModel
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string PayStatus { get; set; }
    }
}
