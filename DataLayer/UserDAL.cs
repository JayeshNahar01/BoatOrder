using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient.Server;

namespace DataLayer
{
    public class UserDAL
    {
        public bool AddCustomer(Users entity)                                   // to save the new customers
        {
            try
            {
                using (BoatContext custOrderContext = new BoatContext())
                {
                    custOrderContext.Users.Add(entity);
                    custOrderContext.SaveChanges();
                    return true;
                }

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Update(Users entity)                                // to update the already registered customer details
        {
            try
            {
                using (BoatContext custOrderContext = new BoatContext())
                {
                    var result = custOrderContext.Users.Where(m => m.ID == entity.ID).FirstOrDefault();
                    if (result != null)
                    {
                        //result.ID = entity.ID;
                        result.Name = entity.Name;
                        result.EmailID = entity.EmailID;
                        result.PhoneNo = entity.PhoneNo;
                        result.Password = entity.Password;
                        result.Address = result.Address;
                        result.City = result.City;
                        custOrderContext.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(Users entity)                               // to delete select field from customers information
        {
            try
            {
                using (BoatContext custOrderContext = new BoatContext())
                {
                    var result = custOrderContext.Users.Where(m => m.ID == entity.ID).FirstOrDefault();
                    if (result != null)
                    {
                        custOrderContext.Users.Remove(result);
                        custOrderContext.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

            }
            catch (Exception ex)
            {
                return false;

            }
        }

        public Users GetByID(int? id)
        {
            try
            {
                using (BoatContext dbContext = new BoatContext())
                {
                    string email_id = Convert.ToString(id);
                    var result = dbContext.Users.Where(x => x.ID == id).FirstOrDefault();
                    return result;
                }

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Users GetByEmail(string emailid)
        {
            try
            {
                using (BoatContext dbContext = new BoatContext())
                {
                    string email_id = Convert.ToString(emailid);
                    var result = dbContext.Users.Where(x => x.EmailID == emailid).FirstOrDefault();
                    return result;
                }

            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public ICollection<Users> GetAll()                          // to retrive info of all customers
        {
            try
            {
                using (BoatContext custOrderContext = new BoatContext())
                {
                    var result = custOrderContext.Users.ToList();
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
        