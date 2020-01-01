using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesterCore.Interface;

namespace TesterCore.Models
{
    public class TestWhithCloseAns:ITest
    {
        public Guid TestId { get; set; }
        public TestType Testtype { get; set; }
        public string Question { get; set; }
        public Guid OwnerId { get; set; }
        public DateTime CreateDate { get; set; }
        public string Description { get; set; }
    }
}
