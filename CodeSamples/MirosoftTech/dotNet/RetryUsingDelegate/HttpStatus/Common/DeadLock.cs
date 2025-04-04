using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HttpStatus.Common
{
    public class DeadLock
    {
        public TResult RetryDeadLock<TResult>(Func<TResult> function)
        {
            int retry = 0;
            do
            {
                try
                {
                    return function.Invoke();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 1205 || ex.Number == -2)
                    {
                        ++retry;
                    }
                }
            } while (retry > 3);
            throw new Exception("Tries Failed");
        }
    }
}