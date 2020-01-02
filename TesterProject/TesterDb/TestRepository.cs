using System;
using System.Collections.Generic;
using System.Text;

namespace TesterDb
{
    public class TestRepository
    {
        private MyDbContext db;
        public TestRepository(MyDbContext db)
        {
            this.db = db;
        }
    }
}
