using BusinessObject;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class BirdRepo : IBirdRepo
    {
        public void AddNew(Bird bird) => BirdDAO.AddNew(bird);
        

        public void DeleteBird(Bird Bird) => BirdDAO.DeleteBird(Bird);
        

        public Bird GetBirdById(int id) => BirdDAO.GetBirdById(id);

        public List<Bird> GetBirds() => BirdDAO.GetBirds();

        public List<Bird> GetBirdsbyBirdID(int BirdID) => BirdDAO.GetBirdsbyBirdID((int)BirdID);
       

        public void SaveBird(Bird Bird) => BirdDAO.SaveBird(Bird);

        public void UpdateBird(Bird Bird) => BirdDAO.UpdateBird(Bird);
    }
}
