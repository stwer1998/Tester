using System;
using System.Collections.Generic;
using System.Text;
using TesterCore.Interface;

namespace TesterCore.Models
{
    public class Answer
    {
        public Guid AnswerId { get; set; }
        public Guid TestId { get; set; }
        public bool Status { get; set; }
        public string AnswerVal { get; set; }
    }
}
