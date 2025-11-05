using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;


namespace Repositories
{
    public interface IBirdRepo
    {
        List<Bird> GetBirds();
        List<Bird> GetBirdsbyBirdID(int BirdID);

        Bird GetBirdById(int id);
        void SaveBird(Bird Bird);
        void DeleteBird(Bird Bird);
        void UpdateBird(Bird Bird);
        void AddNew(Bird bird);
    }
}
