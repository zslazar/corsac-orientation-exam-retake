using ErrorReporter.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErrorReporter.Repositories
{
    public class ErrorRepository
    {
        private ErrorContext errorContext;

        public ErrorRepository(ErrorContext errorContext)
        {
            this.errorContext = errorContext;
        }
    }
}
