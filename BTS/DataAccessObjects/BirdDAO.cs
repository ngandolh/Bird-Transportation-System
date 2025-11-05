using BusinessObject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class BirdDAO
    {

        // Xử lý Singleton bổ sung
        public static List<Bird> GetBirds()
        {
            List<Bird> listBirds = new List<Bird>();
            try
            {
                using (var context = new BTSContext())
                {
                    listBirds = context.Birds.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return listBirds;
        }

        public static List<Bird> GetBirdsbyBirdID(int BirdID)
        {
            List<Bird> listBirds = new List<Bird>();
            try
            {
                using (var context = new BTSContext())
                {
                    listBirds = context.Birds.Where(o => o.BirdId == BirdID).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return listBirds;
        }
        public static Bird GetBirdById(int id)
        {
            Bird Bird = new Bird();
            try
            {
                using (var context = new BTSContext())
                {
                    Bird = context.Birds.SingleOrDefault(m => m.BirdId == id);
                        
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Bird;
        }

        public static void SaveBird(Bird Bird)
        {
            try
            {
                using (var context = new BTSContext())
                {
                    context.Birds.Add(Bird); // Thêm DbSet<Bird>
                    context.SaveChanges(); // Cập nhập DB
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void DeleteBird(Bird Bird)
        {
            try
            {
                using (var context = new BTSContext())
                {
                    var p1 = context.Birds.SingleOrDefault(m => m.BirdId == Bird.BirdId);
                    context.Birds.Remove(p1); // remove ra khỏi Collection(DbSet)
                    context.SaveChanges(); // Cập nhập database
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void UpdateBird(Bird Bird)
        {
            try
            {
                using (var context = new BTSContext())
                {
                    context.Entry<Bird>(Bird).State = EntityState.Modified; //gán trạng  thái
                    context.SaveChanges(); // cập nhập Database
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void AddNew(Bird bird)
        {
            try
            {
                using (var context = new BTSContext())
                {

                    context.Birds.Add(bird); // Add the new bird to the DbSet
                    context.SaveChanges(); // Save changes to the database
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
