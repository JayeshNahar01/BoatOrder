using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer
{
    public class CustomerDAL
    {

        public Customer GetByEmailID(string emailid)                              // to retrive info of specific customer
        {
            try
            {
                using (BoatContext custOrderContext = new BoatContext())
                {

                    var result = custOrderContext.Customers.Where(m => m.EmailID == emailid).FirstOrDefault();
                    return result;
                }

            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public Customer GetByID(int? id)
        {
            try
            {
                using (BoatContext dbContext = new BoatContext())
                {

                    var result = dbContext.Customers.Where(x => x.ID == id).FirstOrDefault();
                    return result;
                }

            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
